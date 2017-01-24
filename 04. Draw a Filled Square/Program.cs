using System;


namespace _04.Draw_a_Filled_Square
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintTopAndBottom(number);
            PrintMiddle(number);
            PrintTopAndBottom(number);

        }
        public static void PrintTopAndBottom(int number)
        {
            Console.WriteLine(new string('-', 2 * number));
        }
        public static void PrintMiddle(int number)
        {
            for (int i = 0; i < number - 2; i++)
            {
                Console.Write("-");
                for (int j = 1; j < number; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
        }

    }
}