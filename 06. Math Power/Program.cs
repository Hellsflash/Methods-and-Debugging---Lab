using System;


namespace _06.Math_Power
{
    public class Program
    {
       public static void Main(string[] args)

        {
            double number = double.Parse(Console.ReadLine());
            double toPower = double.Parse(Console.ReadLine());
            var powerOfNumber = CalculateThePowerOfNumber(number, toPower);

            Console.WriteLine(powerOfNumber);
        }

        public static double CalculateThePowerOfNumber(double number, double toPower)

        {
            

            double result = 1;

            for (int i = 1; i <= toPower; i++)
            {
                result *= number;
            }
            return result;
            
        }
    }
}
