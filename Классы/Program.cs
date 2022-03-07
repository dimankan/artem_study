using ConsoleArt.Classes;
using Meth;
using System;

using System.Collections.Generic;

namespace Классы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region InvokeRun
            //RunCodeWars();
            //RunPeople();
            //RunCar(); 
            #endregion

        }

        #region RunMethods

        private static void RunCar()
        {
            Car bmw = new Car("x6", 5000000);
            Car vw = new Car("Passat", 3000000);

            bmw.YearOfMade = 2015;
            Console.WriteLine(bmw.YearOfMade);

            bmw.ShowInfo();

            //bmw.ShowInfo();
            //vw.ShowInfo();
        }
        private static void RunCodeWars()
        {
            int x = CodeWars.SumMul(5, 20);
            Console.WriteLine(x);
        }
        public static void RunPeople()
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

            People[] peoples = new People[] { artem, people1, people2, people3 };
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
                Console.WriteLine(item.SalaRy);
            }
            for (int i = 0; i < peoples1.Count; i++)
            {
                Console.WriteLine(peoples1[i].Yers);
            }


        }

        #endregion

    }
}

