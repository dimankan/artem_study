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

            bmw.ShowInfo();
            vw.ShowInfo();

            Car.CalcPlusShow(5,6);
            StaticMethods.CalcMinusShow(5,6);
            StaticMethods.CalcMultiplayShow(5,6);

            System.Console.WriteLine();

            ElectroCar tesla = new ElectroCar();
            tesla.ShowInfo();

        }
    }

    class Car
    {
        private protected string _model;
        int _price;

        public Car(string x, int y)
        {
            _model = x;
            _price = y;
        }

        public Car()
        {

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

    class ElectroCar : Car
    {
        public void MethodElectro()
        {
            Console.WriteLine(_model);
        }
        
    }
}
