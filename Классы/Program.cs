using System;
using Meth;
using Meth.oneFolder;


namespace Классы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new Car("x6", 5000000);
            Car vw = new Car("Passat", 3000000);

            bmw.ShowInfo();
            vw.ShowInfo();

            Car.CalcPlusShow(5,6);
            StaticMethods.CalcMinusShow(5,6);
            StaticMethods.CalcMultiplayShow(5,6);

            Class1 class1 = new Class1();
        }
    }

    class Car
    {
        private string _model;
        int _price;

        public Car(string x, int y)
        {
            _model = x;
            _price = y;
        }

        

        public void ShowInfo()
        {
            Console.WriteLine($"Модель: {_model}, стоит: {_price}");
        }


        public static void CalcPlusShow(int x, int y)
        {
            //Console.WriteLine($"{x+y}");
            Console.WriteLine($"{x + y}");
        }
    }
}
