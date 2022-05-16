using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMD_Xpuct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c time /t",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
            };

            var psi2 = new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/c chcp 65001 & ipconfig",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
            };
             
           


            Process process = Process.Start(psi2);

            textBox1.Text = process.StandardOutput.ReadToEnd();
            label1.Text = process.StandardOutput.ReadToEnd();

        }

        
    }
}
