using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;
using System.Timers;

namespace MQTT
{
    public partial class Form1 : Form
    {
        int check = 0;
        int index;
        int min;

        private MqttClient client;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_sub_Click(object sender, EventArgs e)
        {
            string brokerAddress = textBox1_broker.Text;
            int brokerPort = int.Parse(textBox2_port.Text);
            string topic = textBox1_topic.Text;

            client = new MqttClient(brokerAddress, brokerPort, false, null, null, 0);
            client.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceived;
            try
            {
                client.Connect(textBox3_id.Text, textBox4_user.Text, textBox5_pass.Text);   // connect mqtt sever

            }
            catch (Exception)
            {
                Console.WriteLine("pass");
            }
            if (topic == "" && client.IsConnected)
            {
                topic = "1";
                MessageBox.Show(
                                "Please Enter Topic",
                                "แจ้งตือน",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );
            }
            else if (!client.IsConnected && topic == "")
            {
                MessageBox.Show(
                                "Conect Fail! and Please Enter Topic",
                                "แจ้งตือน",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );
            }
            else if (!client.IsConnected && topic != "")
            {
                MessageBox.Show(
                                "Conecting Fail! ",
                                "แจ้งตือน",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );
            }
            else if (client.IsConnected && topic != "")
            {
                button1_sub.BackColor = Color.GreenYellow;
                unsub.BackColor = Color.White;
                label9.Text = "Connected";
                label9.BackColor = Color.GreenYellow;
                client.Subscribe(new string[] { topic }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE });
                int currentIndex = tabControl1.SelectedIndex;
                int nextIndex = (currentIndex + 1) % tabControl1.TabCount;
                tabControl1.SelectedIndex = nextIndex;

                min = 15 * 60;
                timer1.Start();
            }

        }
        private void MqttClient_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            try
            {
                min = 15 * 60;
                DateTime now = DateTime.Now;
                string message = Encoding.UTF8.GetString(e.Message);
                dynamic jsonData = JsonConvert.DeserializeObject(message);
                string msg = jsonData[0]["data"];
                string msg1 = jsonData[0]["devEUI"];
                string msg2 = jsonData[0]["rssi"];
                //   int data = msg.Count();
                int row;
                int rowCount = table.RowCount;
                for (row = 0; row < rowCount; row++)
                {
                    if (table[0, row].Value.ToString() == msg1)
                    {
                        DataGridViewRow newdata = table.Rows[row];
                        newdata.Cells[1].Value = msg;
                        newdata.Cells[2].Value = msg2;
                        newdata.Cells[3].Value = now;
                        table[4, row].Value = "Connected";
                        table[4, row].Style.BackColor = Color.GreenYellow;
                    }
                    else
                    {
                        check = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void unsub_Click_1(object sender, EventArgs e)
        {
            string topic = textBox1_topic.Text;
            timer1.Stop();
            min = 15 * 60;
            textBox1_topic.Clear();
            if (client != null && client.IsConnected)
            {
                button1_sub.BackColor = Color.White;
                unsub.BackColor = Color.Red;
                label9.Text = "Disconnect";
                label9.BackColor = Color.Red;

                client.Unsubscribe(new string[] { topic });
                client.Disconnect();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            table.Rows.Add(textBox1_devEUI.Text);
            textBox1_devEUI.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            index = table.CurrentCell.RowIndex;
            table.Rows.RemoveAt(index);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            min--;
            if (min < 0)
            {
                string topic = textBox1_topic.Text;
                timer1.Stop();
                client.Unsubscribe(new string[] { topic });
                client.Disconnect();

                label9.Text = "Disconnect";
                label9.BackColor = Color.Red;
                int currentIndex = tabControl1.SelectedIndex;
                int backIndex = (currentIndex - 1) % tabControl1.TabCount;
                tabControl1.SelectedIndex = backIndex;
                button1_sub.BackColor = Color.White;
                unsub.BackColor = Color.Red;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int row;
            int rowCount = table.RowCount;
            for (row = 0; row < rowCount; row++)
            {
                table[4, row].Value = "Disconnect";
                table[4, row].Style.BackColor = Color.Red;
            }
        }
    }
}

