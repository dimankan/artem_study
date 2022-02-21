using Meth;
using System;
using System.Collections.Generic;

namespace Классы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = SumMul(5, 20);
            Console.WriteLine(x);
        }
        public static bool isDivisible(long n, long x, long y)
        {
            bool result = false;
            bool a = x % n == 0;
            bool b = y % n == 0;
            if (a && b)
            {
                result = true;
            }

            return result;
        }
        public static int[] CountPositivesSumNegatives(int[] input)
        {

            if (input == null)
            {
                return new int[0] { };
            }

            else if (input.Length == 0)
            {
                return new int[0] { };
            }

            int[] result = { 0, 0 };

            foreach (var item in input)
            {
                if (item > 0)
                {
                    result[0] += 1;
                }
                else if (item < 0)
                {
                    result[1] += item;
                }

            }
            return result;


        }
        public static int Remainder(int a, int b)
        {
           int result = 0;
            if (a > b)
            {
                result = a % b;
            }
            else if (a < b)
            {
                result = b % a;
            }
            else
            {
                throw new DivideByZeroException();
            }
            

            return result;
        }
        public static string CannonsReady(Dictionary<string, string> gunners)
        {
            string result = "";
            int count = gunners.Count;
            int countReady = 0;
            foreach (var item in gunners)
            {
                if (item.Value == "aye")
                {
                    countReady++;
                }
            }
            if (countReady == count)
            {
                result = "Fire!";
            }
            else
            {
                result = "Shiver me timbers!";
            }
            return result;
        }

        public static int SumMul(int n, int m)
        {
           if (n == 0)
            {
                throw new ArgumentException();
            }
           if (n > m)
            {
                throw new ArgumentException();
            }
           int result = 0;
            int temp = n;
            while (true)
            {
                if (m < temp)
                {
                    break;
                }
                result += temp;
                temp += n;
            }
            return result;
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