using System;


namespace _08.Multiply_Evens_by_Odds
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = MultipleOfEavensAndOod(number);
            Console.WriteLine(Math.Abs(result));

        }
        public static int MultipleOfEavensAndOod(int number)
        {
            int sumEaven = SumOfEavenDigits(number);
            int sumOod = SumOfOodDigits(number);
            return sumEaven*sumOod;
        }
        public static int SumOfEavenDigits(int number)
        {
            int sum = 0;
            while (number >0||number<0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                number /= 10;
            }
            return sum;
        }
        public static int SumOfOodDigits(int number)
        {
            int sum = 0;
            while (number > 0|| number<0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                number /= 10;
            }
            return sum;
        }
    }
}
