using Demo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Classes
{
    public class Medik : Abstract.AbstractInfo, IPeople
    {
        public Medik(string name, int age) : base(name, age)
        {
        }

        public void Show(string name)
        {
            System.Windows.Forms.MessageBox.Show($"Vrach: {name}");
        }

        public override void ShowAge()
        {
            
        }
        public override void SomeMethod()
        {
            System.Windows.Forms.MessageBox.Show("Medik");
        }
    }
}
