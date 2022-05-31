using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstract
{
    public abstract class AbstractInfo
    {
        protected AbstractInfo(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public void ShowName()
        {
            System.Windows.Forms.MessageBox.Show(Name);
        }

        public abstract void ShowAge();

        public virtual void SomeMethod()
        {
            System.Windows.Forms.MessageBox.Show("Abstract");
        }

    }
}
