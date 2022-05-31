using Demo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Classes
{
    internal class Bomj : AbstractInfo
    {
        public Bomj(string name, int age) : base(name, age)
        {
        }


        public override void ShowAge()
        {
            
        }

        public override void SomeMethod()
        {
            System.Windows.Forms.MessageBox.Show("Bomj");
        }
    }
}
