using ConsoleApp1;
using System;

namespace Application
{

    public class Square : IShape
    {
        public void CalculateArea(int length, int breadth)
        {
            int area = length * length;
            Console.WriteLine("Area of Square is : " + area);
        }

        public void CalculatePerimeter(int length, int breadth)
        {
            int result = 4 * length;
            Console.WriteLine("Perimeter of Square is : " + result);
        }
    }

    public class Triangle : AbstractShape
    {
        //public override void CalculateArea(int length, int breadth)
        //{
        //    Console.WriteLine("Area of Triangle is : " + 700);
        //}

        public override void CalculatePerimeter(int length, int breadth)
        {
            var area = length * breadth * 0.2;
            Console.WriteLine("Perimeter of Triangle is : " + area);
        }
    }



    public abstract class AbstractShape
    {
        public virtual void CalculateArea(int length, int breadth)
        {
            Console.WriteLine("Area of Shape is : " + (length + breadth));
        }

        //public virtual void CalculatePerimeter(int length, int breadth)
        //{
        //    Console.WriteLine("Area of Shape is : " + (length + breadth));
        //}

        public abstract void CalculatePerimeter(int length, int breadth);

    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a Demo on understanding interface!");

            IShape objShape1 = new Rectangle();
            objShape1.CalculateArea(80, 30);
            objShape1.CalculatePerimeter(80, 30);


            Square objShape2 = new Square();
            objShape2.CalculateArea(10, 9);
            objShape2.CalculatePerimeter(10, 30);

            Triangle obj3 = new Triangle();
            obj3.CalculateArea(10, 4);
            obj3.CalculatePerimeter(10, 20);
        }
    }
}
