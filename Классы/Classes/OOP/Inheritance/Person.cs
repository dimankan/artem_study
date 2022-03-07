using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArt.Classes.OOP.Inheritance
{
    public class Person
    {
        private string _name = "";

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //public Person()
        //{

        //}
        public Person(string name)
        {
            Name = name;
        }

        public void Print()
        {
            Console.WriteLine(Name);
        }
    }

    class Employee : Person
    {
        public string Company { get; set; }

        public Employee(string name, string company) : base(name)
        {
            Company = company;
        }

        //public Employee(string name, string company) : base()    // ! Ошибка
        //{
        //    Name = name;
        //    Company = company;
        //}
    }
        class Client : Person
    {
        public string Bank { get; set; }
        public Client(string name, string bank) : base(name)
        {
            Bank = bank;
        }
    }


}
