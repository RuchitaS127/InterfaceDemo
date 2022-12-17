using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Rectangle : IShape
    {
        public void CalculateArea(int length, int breadth)
        {
            int area = length * breadth;
            Console.WriteLine("Area of Rectangle is : " + area);
        }

        public void CalculatePerimeter(int length, int breadth)
        {
            int result = 2 * (length + breadth);
            Console.WriteLine("Perimeter of Rectangle is : " + result);
        }
    }
}
