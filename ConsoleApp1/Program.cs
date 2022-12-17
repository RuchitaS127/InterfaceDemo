using System;

// See https://aka.ms/new-console-template for more information


namespace Application
{

    interface IShape 
    {
        void CalculateArea(int length, int breadth);

        void CalculatePerimeter(int length, int breadth);

    }

    public class Rectangle : IShape
    {
        public void CalculateArea(int length, int breadth)
        {
            int area = length * breadth;
            Console.WriteLine("Area of Rectangle is : " + area);
        }

        public void CalculatePerimeter(int length, int breadth)
        {
            int result = 2*(length + breadth);
            Console.WriteLine("Perimeter of Rectangle is : " + result);
        }
    }

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


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a Demo on understanding interface!");

            IShape objShape1 = new Rectangle();
            objShape1.CalculateArea(80, 30);
            objShape1.CalculatePerimeter(80, 30);


            IShape objShape2 = new Square();
            objShape2.CalculateArea(10, 9);
            objShape2.CalculatePerimeter(10, 30);
        }
    }
}

//IShape shape = new IShape(); 