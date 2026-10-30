using System;

namespace ConsoleApp
{
    class Rectangle
    {
        public double height;
        public double width;

        public void Show()
        {
            Console.WriteLine($"Высота: {height}, Ширина: {width}");
        }

        public double Perimeter()
        {
            return (2 * height) + (2 * width);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle myRect = new Rectangle();

            myRect.height = 2;
            myRect.width = 3;

            Console.WriteLine("Данные прямоугольника:");
            myRect.Show();

            double p = myRect.Perimeter();
            Console.WriteLine($"Периметр прямоугольника: {p}");

            Console.ReadLine();
        }
    }
}