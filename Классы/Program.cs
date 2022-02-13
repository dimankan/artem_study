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

            //int x = vw._price;
            //vw.ChangePrice(2323);

            //vw.Price = 232; // SET - Установка
            Console.WriteLine(vw.Price); // GET - Считывание
            int d = vw.Price; // GET - Считывание


            string result = bmw.Info;
            Console.WriteLine(result);


            //bmw.ShowInfo();
            //vw.ShowInfo();


        }
    }

    class Car
    {
        private protected string _model;
        int _price;
        //private int _yearOfMade;

        public int YearOfMade { get; set; }

        public int Price
        {
            get { return _price; }
            private set
            {

                if (value < 0 || value > 100000)
                {
                    Console.WriteLine("Ты че ебанутый? СТолько тачка не стоит");
                }
                else
                {
                    _price = value;
                }
            }
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
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Модель: {_model}, стоит: {_price}");
        }


        public static void CalcPlusShow(int x, int y)
        {
            Console.WriteLine($"{x + y}");
        }
    }

}
