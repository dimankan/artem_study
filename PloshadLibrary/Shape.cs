using System;
using System.Collections.Generic;

namespace PloshadLibrary
{
    public abstract class Shape
    {
        // абстрактный метод для получения периметра
        public abstract double GetPerimeter();

        // абстрактный метод для получения площади
        public abstract double GetArea();
    }

    public class Triangle : Shape
    {
        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        private double Side1 { get; set; }
        private double Side2 { get; set; }
        private double Side3 { get; set; }

        public bool IsRight
        {
            get
            {
                bool result = false;

                List<double> list = new List<double>() { Side1, Side2, Side3 };
                list.Sort();

                if (Math.Sqrt(list[2]* list[2]) == Math.Sqrt(list[0]* list[0]+ list[1] * list[1]))
                {
                    result = true;
                }
                return result;
            }
        }


        // переопределение получения периметра
        public override double GetPerimeter()
        {
            return Side1 + Side2 + Side3;
        }


        // переопрелеление получения площади
        public override double GetArea()
        {
            double result = 0;

            double polupirimetr = GetPerimeter() / 2;

            result = Math.Sqrt(polupirimetr * (polupirimetr - Side1) * (polupirimetr - Side2) * (polupirimetr - Side3));

            return result;
        }
    }

    public class Circle : Shape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        private double Radius { get; set; }

        public override double GetPerimeter() => Radius * 2 * Math.PI;
        public override double GetArea() => Radius * Radius * Math.PI;
    }
   
}
