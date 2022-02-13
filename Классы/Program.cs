using Meth;
using System;
using System.Collections.Generic;

namespace Классы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            People artem = new People();
            artem.Name = "Dima";
            artem.Sname = "Vor";
            artem.Yers = 33;
            artem.Show();

            People people = new People("Artem");
           // people.Yers = 155; 
            people.Show();

            People people1 = new People("Artem", "Petrov");
            people1.Show();

            People people2 = new People("Artem", "Petrov", 150);
            people2.Show();

            People people3 = new People("Vanya", "Grigorev", 26, 45500);
            people3.Show();

            People[] peoples = new People[] {artem, people1, people2, people3};
            foreach (People item in peoples)
            {
                Console.WriteLine(item.Name);
            }
            for (int i = 0; i < peoples.Length; i++)
            {
                Console.WriteLine(peoples[i].Sname);
            }
            List<People> peoples1 = new List<People>() { artem, people1, people2, people3 };
            foreach (People item in peoples1)
            {
                Console.WriteLine(item.SalaRys);
            }
            for (int i = 0; i < peoples1.Count; i++)
            {
                Console.WriteLine(peoples1[i].Yers);
            }

        }
    }
    class People
    {
        private string _name;
        string _sname;
        public int yers;


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Sname
        {
            get { return _sname; }
            set { _sname = value; }
        }
        public int Yers
        {
            get { return yers; }
            set
            {
                if (value < 0 || value > 120)
                {
                    Console.WriteLine("Столько люди не живут!");
                }
                else
                {
                    yers = value;
                }
            }
        }
        public int SalaRy { get; set; }
        public People(string a = "неизвестно", string b = "неизвестно", int c = 0, int d = 0)
        {
            Name = a;
            Sname = b;
            Yers = c;
            SalaRy = d;
        }

        public void Show()
        {
            Console.WriteLine($"Имя:{_name} Фамилия:{_sname} Возраст:{yers} Ваша зп:{SalaRy}");
        }
    }
}

#region Черновик
/*
  internal class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new Car("x6", 5000000);
            Car vw = new Car("Passat", 3000000);

            bmw.YearOfMade = 2015;
            Console.WriteLine(bmw.YearOfMade);

            bmw.ShowInfo();

            //bmw.ShowInfo();
            //vw.ShowInfo();


        }
    }

    class Car
    {
        private protected string _model = "Volvo";
        int _price;
        //private int _yearOfMade;


        public int YearOfMade { get; set; }

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string Info
        {
            get { return $"{_model} стоит {_price}"; }
        }


        //public void ChangePrice(int x)
        //{
        //    _price = x;
        //}




        public Car(string x, int y)
        {
            _model = x;
            Price = y;
            YearOfMade = 3423;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Модель: {_model}, стоит: {_price}, год производства {YearOfMade}");
        }


        public static void CalcPlusShow(int x, int y)
        {
            Console.WriteLine($"{x + y}");
        }
    }

 */
#endregion