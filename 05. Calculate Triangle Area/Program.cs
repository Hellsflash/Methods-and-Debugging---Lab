using System;

namespace _05.Calculate_Triangle_Area
{
   public class Program
    {
        public static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = CalculateTriangleArea(width, height);
            Console.WriteLine(area);

        }

       public static double CalculateTriangleArea(double width, double height)
        {
            return width * height / 2;
        }

    }
}
