using Demo.Abstract;
using Demo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Classes
{
    public class Worker : AbstractInfo, IPeople, IDrink
    {
        public int Salary { get; set; }

        public Worker(string name, int age, int salary) : base(name, age)
        {
            Salary = salary;
        }

        public void Show(string name)
        {
            System.Windows.Forms.MessageBox.Show($"Рабочий: {name}");
        }


        public void ShowDrink(string drink)
        {
            // SDa
        }
        public override void ShowAge()
        {
            throw new NotImplementedException();
        }
    }
}
