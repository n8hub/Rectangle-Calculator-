using System;
using System.ComponentModel.DataAnnotations;

namespace Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5.0, 3.0);
            rectangle.GetArea(5.0, 3.0);
            rectangle.GetPerimeter(5.0, 3.0);
            Rectangle rectangle2 = new Rectangle(7.5, 4.5);
            rectangle2.GetArea(7.5, 4.5);
            rectangle2.GetPerimeter(7.5, 4.5);

        }
    }
    public class Rectangle
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public void GetArea(double length, double width)
        {
            double area = length * width;
            Console.WriteLine("Area of Rectangle: " + area);

        }
        public void GetPerimeter(double length, double width)
        {
            double perimeter = 2 * (length + width);
            Console.WriteLine("Perimeter of Rectangle: " + perimeter);
        }
    }


}