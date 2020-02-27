namespace WindowsFormsAppMCLab2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonOpenPort = new System.Windows.Forms.Button();
            this.buttonAlgo5 = new System.Windows.Forms.Button();
            this.buttonAlgo8 = new System.Windows.Forms.Button();
            this.led1 = new System.Windows.Forms.Panel();
            this.led2 = new System.Windows.Forms.Panel();
            this.led3 = new System.Windows.Forms.Panel();
            this.led4 = new System.Windows.Forms.Panel();
            this.led6 = new System.Windows.Forms.Panel();
            this.led5 = new System.Windows.Forms.Panel();
            this.led7 = new System.Windows.Forms.Panel();
            this.led8 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(337, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // buttonOpenPort
            // 
            this.buttonOpenPort.BackColor = System.Drawing.Color.White;
            this.buttonOpenPort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonOpenPort.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenPort.Location = new System.Drawing.Point(473, 30);
            this.buttonOpenPort.Name = "buttonOpenPort";
            this.buttonOpenPort.Size = new System.Drawing.Size(122, 45);
            this.buttonOpenPort.TabIndex = 1;
            this.buttonOpenPort.Text = "Open";
            this.buttonOpenPort.UseVisualStyleBackColor = false;
            this.buttonOpenPort.Click += new System.EventHandler(this.buttonOpenPort_Click);
            // 
            // buttonAlgo5
            // 
            this.buttonAlgo5.BackColor = System.Drawing.Color.White;
            this.buttonAlgo5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlgo5.Location = new System.Drawing.Point(114, 204);
            this.buttonAlgo5.Name = "buttonAlgo5";
            this.buttonAlgo5.Size = new System.Drawing.Size(175, 75);
            this.buttonAlgo5.TabIndex = 2;
            this.buttonAlgo5.Text = "Algorithm 5";
            this.buttonAlgo5.UseVisualStyleBackColor = false;
            this.buttonAlgo5.Visible = false;
            this.buttonAlgo5.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonAlgo8
            // 
            this.buttonAlgo8.BackColor = System.Drawing.Color.White;
            this.buttonAlgo8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlgo8.Location = new System.Drawing.Point(483, 204);
            this.buttonAlgo8.Name = "buttonAlgo8";
            this.buttonAlgo8.Size = new System.Drawing.Size(175, 75);
            this.buttonAlgo8.TabIndex = 3;
            this.buttonAlgo8.Text = "Algorithm 8";
            this.buttonAlgo8.UseVisualStyleBackColor = false;
            this.buttonAlgo8.Visible = false;
            this.buttonAlgo8.Click += new System.EventHandler(this.button3_Click);
            // 
            // led1
            // 
            this.led1.BackColor = System.Drawing.Color.Gainsboro;
            this.led1.Location = new System.Drawing.Point(57, 333);
            this.led1.Name = "led1";
            this.led1.Size = new System.Drawing.Size(45, 45);
            this.led1.TabIndex = 4;
            // 
            // led2
            // 
            this.led2.BackColor = System.Drawing.Color.Gainsboro;
            this.led2.Location = new System.Drawing.Point(145, 333);
            this.led2.Name = "led2";
            this.led2.Size = new System.Drawing.Size(45, 45);
            this.led2.TabIndex = 5;
            // 
            // led3
            // 
            this.led3.BackColor = System.Drawing.Color.Gainsboro;
            this.led3.Location = new System.Drawing.Point(235, 333);
            this.led3.Name = "led3";
            this.led3.Size = new System.Drawing.Size(45, 45);
            this.led3.TabIndex = 6;
            // 
            // led4
            // 
            this.led4.BackColor = System.Drawing.Color.Gainsboro;
            this.led4.Location = new System.Drawing.Point(328, 333);
            this.led4.Name = "led4";
            this.led4.Size = new System.Drawing.Size(45, 45);
            this.led4.TabIndex = 5;
            // 
            // led6
            // 
            this.led6.BackColor = System.Drawing.Color.Gainsboro;
            this.led6.Location = new System.Drawing.Point(511, 333);
            this.led6.Name = "led6";
            this.led6.Size = new System.Drawing.Size(45, 45);
            this.led6.TabIndex = 5;
            // 
            // led5
            // 
            this.led5.BackColor = System.Drawing.Color.Gainsboro;
            this.led5.Location = new System.Drawing.Point(423, 333);
            this.led5.Name = "led5";
            this.led5.Size = new System.Drawing.Size(45, 45);
            this.led5.TabIndex = 5;
            // 
            // led7
            // 
            this.led7.BackColor = System.Drawing.Color.Gainsboro;
            this.led7.Location = new System.Drawing.Point(600, 333);
            this.led7.Name = "led7";
            this.led7.Size = new System.Drawing.Size(45, 45);
            this.led7.TabIndex = 7;
            // 
            // led8
            // 
            this.led8.BackColor = System.Drawing.Color.Gainsboro;
            this.led8.Location = new System.Drawing.Point(689, 333);
            this.led8.Name = "led8";
            this.led8.Size = new System.Drawing.Size(45, 45);
            this.led8.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "COM port:";
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // timer
            // 
            this.timer.Interval = 550;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(778, 444);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.led8);
            this.Controls.Add(this.led7);
            this.Controls.Add(this.led4);
            this.Controls.Add(this.led6);
            this.Controls.Add(this.led5);
            this.Controls.Add(this.led3);
            this.Controls.Add(this.led2);
            this.Controls.Add(this.led1);
            this.Controls.Add(this.buttonAlgo8);
            this.Controls.Add(this.buttonAlgo5);
            this.Controls.Add(this.buttonOpenPort);
            this.Controls.Add(this.comboBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "Lab_2";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonOpenPort;
        private System.Windows.Forms.Button buttonAlgo5;
        private System.Windows.Forms.Button buttonAlgo8;
        private System.Windows.Forms.Panel led1;
        private System.Windows.Forms.Panel led2;
        private System.Windows.Forms.Panel led3;
        private System.Windows.Forms.Panel led4;
        private System.Windows.Forms.Panel led6;
        private System.Windows.Forms.Panel led5;
        private System.Windows.Forms.Panel led7;
        private System.Windows.Forms.Panel led8;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Timer timer;
    }
}

