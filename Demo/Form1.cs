using Demo.Abstract;
using Demo.Classes;
using Demo.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(tbInput1.Text);
            int y = Convert.ToInt32(tbInput2.Text);


            int result = 0;
            string resultStr = string.Empty;


            //(result, resultStr) = Delit(x, y);

            //if (!string.IsNullOrEmpty(resultStr))
            //{
            //    MessageBox.Show(resultStr);
            //}


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Polumorph();

            //string str = $"Artem{Environment.NewLine}Petov{Environment.NewLine}27";
            string str = @"Artem 
Petrov
27";


            tbOutput.Text = str;
        }

        private static void Polumorph()
        {
            Bomj bomj = new Bomj("dsfs", 21);
            Medik medik = new Medik("dsfasads", 22);
            Worker worker = new Worker("dsfsads", 23, 432434);

            //bomj.SomeMethod();
            //medik.SomeMethod();

            //AbstractInfo dsdfs = new Bomj("Asda", 33);
            //dsdfs.SomeMethod();

            List<AbstractInfo> list = new List<AbstractInfo>() { bomj, medik, worker };


            //foreach (var item in list)
            //{
            //    item.SomeMethod();
            //}

            List<IPeople> peoples = new List<IPeople>() { medik, worker };

            foreach (var item in peoples)
            {
                item.Show("Artem");
            }
        }
    }
}
