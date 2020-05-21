using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alert_to_serial
{
    public partial class Form1 : Form
    {
        //private readonly string PortName = "COM5";
        //private SerialPort Port;
        private TwitchBot Bot;

        public Form1()
        {
            InitializeComponent();
            //ConnectToArduino();
            Bot = new TwitchBot();
        }

        //private void ConnectToArduino()
        //{
        //    Port = new SerialPort(PortName, 9600, Parity.None, 8, StopBits.One);
        //    Port.Open();
        //    Console.Out.WriteLine("Connected to serial port: " + PortName);
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            Console.Out.WriteLine("Triggering...");
        }

    }
}

//https://dev.twitch.tv/docs/authentication

//https://dev.twitch.tv/docs/api/webhooks-reference

//https://github.com/TwitchLib/TwitchLib