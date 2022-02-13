using Meth;
using System;




namespace Классы
{
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

}
