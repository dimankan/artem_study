using PloshadLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramFigure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btCircle_Click(object sender, EventArgs e)
        {
            try
            {
                double radius = Convert.ToDouble(tbRadius.Text);

                //tbPloshad.Text = (Math.PI * Math.Pow(radius, 2)).ToString();

                Circle circle = new Circle(radius);
                tbPloshad.Text = circle.GetArea().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void btTriangle_Click(object sender, EventArgs e)
        {
            try
            {
                double s1 = Convert.ToDouble(tb1slide.Text);
                double s2 = Convert.ToDouble(tb2slide.Text);
                double s3 = Convert.ToDouble(tb3slide.Text);

                //double polupirimetr = (s1 + s2 + s3) / 2;

                //double ploshad = Math.Sqrt(polupirimetr * (polupirimetr - s1) * (polupirimetr - s2) * (polupirimetr - s3));

                Triangle triangle = new Triangle(s1, s2, s3);


                tbPloshad.Text = triangle.GetArea().ToString();


                if (triangle.IsRight)
                {
                    tbIsRight.Text = "Треугольник прямоугольный";
                    cbIsRight.Checked = true;
                }
                else
                {
                    tbIsRight.Text = "Треугольник НЕ прямоугольный";
                    cbIsRight.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}
