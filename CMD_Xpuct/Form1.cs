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

      
        private void Form1_Load(object sender, EventArgs e)
        {
            tbCurrentAdress.Text = Library.RunCMD("cd");
        }

        private void btRun_Click(object sender, EventArgs e)
        {
            tbOutput.Text = Library.RunCMD(tbCurrentAdress.Text, tbInput.Text, cbCHCP.Text);
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Library.ChooseFolder(tbCurrentAdress.Text);
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            Library.OpenDirectory(tbCurrentAdress.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
