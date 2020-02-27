using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace WindowsFormsAppMCLab2
{
    
    public partial class Form1 : Form
    {
        private const byte algo_5 = 0x5;
        private const byte algo_8 = 0x8;
        private int algorithm;
        private int pin;
        private int k;
        private int sign;
        
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            byte[] b = new byte[1];
            b[0] = algo_5;
            serialPort.Write(b, 0, 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte[] b = new byte[1];
            b[0] = algo_8;
            serialPort.Write(b, 0, 1);
        }

        

        private void buttonOpenPort_Click(object sender, EventArgs e)
        {

            if (!serialPort.IsOpen)
                try
                {
                    serialPort.PortName = comboBox1.Text;
                    serialPort.Open();
                    buttonOpenPort.Text = "Close";
                    comboBox1.Enabled = false;
                    buttonAlgo5.Visible = true;
                    buttonAlgo8.Visible = true;
                }
                catch
                {
                    MessageBox.Show("Port " + comboBox1.Text + " is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            else
            {
                serialPort.Close();
                buttonOpenPort.Text = "Open";
                comboBox1.Enabled = true;
                buttonAlgo5.Visible = false;
                buttonAlgo8.Visible = false;
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(SerialPort.GetPortNames().ToArray());
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            switch ((byte)serialPort.ReadByte())
            {
                case algo_5:
                    if (!timer.Enabled){
                        algorithm = 1;
                        pin = 0;
                        this.BeginInvoke(new ThreadStart(startTimer));
                    }
                    break;
                case algo_8:
                    if (!timer.Enabled) {
                        algorithm = 2;
                        pin = 7;
                        k = 7;
                        sign = 1;
                        this.BeginInvoke(new ThreadStart(startTimer));
                    }
                    break;
                default:break;     
            }
        }

        private void startTimer()
        {
            timer.Start();
            timer.Interval = 550;
           
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            var leds = new[] { led1, led2, led3, led4, led5, led6, led7, led8 };
            for (int i = 0; i < 8; ++i)
                leds[i].BackColor = Color.Gainsboro;
            if (pin > 7 || (algorithm == 2 && k < 0)){
                timer.Stop();  
            }
            if (algorithm == 1 && pin <= 7){
                leds[pin].BackColor = Color.Green;
                if (pin == 6)
                    pin = -1;
                pin += 2;
            }
            if(algorithm == 2 && k >= 0){
                leds[pin].BackColor = Color.Green;
                sign *= -1;
                pin += k * sign;
                --k;    
            }
        }
    }
}
