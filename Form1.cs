using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XDevkit;
using JRPC_Client;

namespace bo2_mod_tool
{
    public partial class Form1 : Form
    {
        IXboxConsole console;
        public Form1() => InitializeComponent();

        //Connect to console
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (console.Connect(out console))
            {
                Connectionlabel.Text = "Current connection status: CONNECTED";
                MessageBox.Show("Connected!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                console.XNotify("Connected");
            }
            else
            {
                Connectionlabel.Text = "Current connection status: FAILED";
                MessageBox.Show("Couldn't connect, try again.");
                console.XNotify("Couldn't connect");
            }
        }

        //Get system temps
        private void GetConsoleInfo_Click(object sender, EventArgs e)
        {
                //Get CPU temperature for system info display
                uint CPU_TEMP = console.GetTemperature(JRPC.TemperatureType.CPU);
                TempCPU.Text = "CPU temp: " + CPU_TEMP + "°C";
                TempCPU.ReadOnly = true;
                //Get GPU temperature for system info display
                uint GPU_TEMP = console.GetTemperature(JRPC.TemperatureType.GPU);
                TempGPU.Text = "GPU temp: " + GPU_TEMP + "°C";
                //Get motherboard temperature for system info display
                uint MOB_TEMP = console.GetTemperature(JRPC.TemperatureType.MotherBoard);
                TempMOB.Text = "Motherboard temp: " + MOB_TEMP + "°C";
            }

        }
    }