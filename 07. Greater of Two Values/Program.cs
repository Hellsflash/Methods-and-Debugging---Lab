using System;

namespace _07.Greater_of_Two_Values
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var type = Console.ReadLine();

            if (type == "int")
            {
                var firstValue = int.Parse(Console.ReadLine());
                var secondValue = int.Parse(Console.ReadLine());
                int maximumValue = GetMax(firstValue, secondValue);
                Console.WriteLine(maximumValue);
            }
            else if (type == "char")
            {
                var firstValue = char.Parse(Console.ReadLine());
                var secondValue = char.Parse(Console.ReadLine());
                char maximumValue = GetMax((char)firstValue, (char)secondValue);
                Console.WriteLine(maximumValue);
            }
            else if (type == "string")
            {
                var firstValue = Console.ReadLine();
                var secondValue = Console.ReadLine();
                string maximumValue = GetMax(firstValue, secondValue);
                Console.WriteLine(maximumValue);
            }


        }

       public static int GetMax(int firstValue, int secondValue)
        {
            if (firstValue >= secondValue)
            {
                return firstValue;
            }
            else
            {
                return secondValue;
            }
        }
       public static char GetMax(char firstValue, char secondValue)
        {
            if (firstValue >= secondValue)
            {
                return firstValue;
            }
            else
            {
                return secondValue;
            }

        }
       public static string GetMax(string firstValue, string secondValue)
        {
            if (firstValue.CompareTo(secondValue) >= 0)
            {
                return firstValue;
            }
            else
            {
                return secondValue;
            }
        }

    }
}

