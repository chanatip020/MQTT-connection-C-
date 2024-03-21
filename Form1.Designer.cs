namespace MQTT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1_topic = new TextBox();
            fileSystemWatcher1 = new FileSystemWatcher();
            button1_sub = new Button();
            unsub = new Button();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox3 = new GroupBox();
            textBox2_port = new TextBox();
            label3 = new Label();
            textBox1_broker = new TextBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            textBox4_user = new TextBox();
            textBox5_pass = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox3_id = new TextBox();
            label7 = new Label();
            tabPage2 = new TabPage();
            label10 = new Label();
            button3 = new Button();
            label9 = new Label();
            table = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            label8 = new Label();
            textBox1_devEUI = new TextBox();
            button2 = new Button();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            SuspendLayout();
            // 
            // textBox1_topic
            // 
            textBox1_topic.Location = new Point(287, 48);
            textBox1_topic.Name = "textBox1_topic";
            textBox1_topic.Size = new Size(190, 23);
            textBox1_topic.TabIndex = 1;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // button1_sub
            // 
            button1_sub.Location = new Point(237, 99);
            button1_sub.Name = "button1_sub";
            button1_sub.Size = new Size(127, 45);
            button1_sub.TabIndex = 5;
            button1_sub.Text = "Connect";
            button1_sub.UseVisualStyleBackColor = true;
            button1_sub.Click += button1_sub_Click;
            // 
            // unsub
            // 
            unsub.Location = new Point(384, 99);
            unsub.Name = "unsub";
            unsub.Size = new Size(127, 45);
            unsub.TabIndex = 4;
            unsub.Text = "Disconnect";
            unsub.UseVisualStyleBackColor = true;
            unsub.Click += unsub_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(176, 48);
            label1.Name = "label1";
            label1.Size = new Size(101, 19);
            label1.TabIndex = 2;
            label1.Text = "Subscribe : ";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 6;
            tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Config";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox2_port);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(textBox1_broker);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(6, 198);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(756, 98);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            groupBox3.Text = "config";
            // 
            // textBox2_port
            // 
            textBox2_port.Location = new Point(433, 43);
            textBox2_port.Name = "textBox2_port";
            textBox2_port.Size = new Size(192, 23);
            textBox2_port.TabIndex = 12;
            textBox2_port.Text = "1883";
            textBox2_port.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(113, 45);
            label3.Name = "label3";
            label3.Size = new Size(33, 16);
            label3.TabIndex = 9;
            label3.Text = "host";
            // 
            // textBox1_broker
            // 
            textBox1_broker.Location = new Point(152, 43);
            textBox1_broker.Name = "textBox1_broker";
            textBox1_broker.Size = new Size(192, 23);
            textBox1_broker.TabIndex = 10;
            textBox1_broker.Text = "180.183.244.91";
            textBox1_broker.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(395, 45);
            label4.Name = "label4";
            label4.Size = new Size(32, 16);
            label4.TabIndex = 11;
            label4.Text = "port";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1_sub);
            groupBox2.Controls.Add(unsub);
            groupBox2.Controls.Add(textBox1_topic);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(6, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(756, 186);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Topic";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4_user);
            groupBox1.Controls.Add(textBox5_pass);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox3_id);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(6, 302);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(756, 90);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Other config";
            // 
            // textBox4_user
            // 
            textBox4_user.Location = new Point(364, 37);
            textBox4_user.Name = "textBox4_user";
            textBox4_user.Size = new Size(93, 23);
            textBox4_user.TabIndex = 17;
            textBox4_user.Text = "zung";
            textBox4_user.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5_pass
            // 
            textBox5_pass.Location = new Point(559, 37);
            textBox5_pass.Name = "textBox5_pass";
            textBox5_pass.Size = new Size(93, 23);
            textBox5_pass.TabIndex = 18;
            textBox5_pass.Text = "zeny";
            textBox5_pass.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(95, 39);
            label5.Name = "label5";
            label5.Size = new Size(61, 16);
            label5.TabIndex = 13;
            label5.Text = "Client ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(287, 39);
            label6.Name = "label6";
            label6.Size = new Size(71, 16);
            label6.TabIndex = 14;
            label6.Text = "Username";
            // 
            // textBox3_id
            // 
            textBox3_id.Location = new Point(162, 37);
            textBox3_id.Name = "textBox3_id";
            textBox3_id.Size = new Size(93, 23);
            textBox3_id.TabIndex = 16;
            textBox3_id.Text = "testmqtt";
            textBox3_id.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(485, 39);
            label7.Name = "label7";
            label7.Size = new Size(68, 16);
            label7.TabIndex = 15;
            label7.Text = "Password";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(table);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(textBox1_devEUI);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(button1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Device list";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(615, 3);
            label10.Name = "label10";
            label10.Size = new Size(66, 21);
            label10.TabIndex = 19;
            label10.Text = "Server : ";
            // 
            // button3
            // 
            button3.Location = new Point(686, 368);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 18;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Red;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(676, 3);
            label9.Name = "label9";
            label9.Size = new Size(86, 21);
            label9.TabIndex = 16;
            label9.Text = "Disconnect";
            // 
            // table
            // 
            table.AllowUserToAddRows = false;
            table.AllowUserToOrderColumns = true;
            table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            table.Location = new Point(5, 35);
            table.Name = "table";
            table.RowTemplate.Height = 25;
            table.Size = new Size(756, 312);
            table.TabIndex = 15;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.NullValue = "64c4bb2512345678";
            Column1.DefaultCellStyle = dataGridViewCellStyle1;
            Column1.HeaderText = "Device EUI";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Data";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "rssi";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Time";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Status";
            Column5.Name = "Column5";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(5, 350);
            label8.Name = "label8";
            label8.Size = new Size(70, 16);
            label8.TabIndex = 14;
            label8.Text = "Device EUI";
            // 
            // textBox1_devEUI
            // 
            textBox1_devEUI.Location = new Point(5, 369);
            textBox1_devEUI.Name = "textBox1_devEUI";
            textBox1_devEUI.Size = new Size(190, 23);
            textBox1_devEUI.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(282, 369);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(201, 369);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "LoRa module Connection Status";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox1_topic;
        private FileSystemWatcher fileSystemWatcher1;
        private Button unsub;
        private Label label1;
        private Button button1_sub;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBox2_port;
        private Label label4;
        private TextBox textBox1_broker;
        private Label label3;
        private TextBox textBox5_pass;
        private TextBox textBox4_user;
        private TextBox textBox3_id;
        private Label label7;
        private Label label6;
        private Label label5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button button2;
        private Button button1;
        private Label label8;
        private TextBox textBox1_devEUI;
        private DataGridView table;
        private Label label9;
        private System.Windows.Forms.Timer timer1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button button3;
        private Label label10;
    }
}