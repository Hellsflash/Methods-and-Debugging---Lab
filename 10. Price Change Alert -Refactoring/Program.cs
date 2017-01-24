using System;


namespace _10.Price_Change_Alert__Refactoring
{
    class PriceChangeAlert
    {
        static void Main()
        {
            int numberOfPrices = int.Parse(Console.ReadLine());
            double threshold = double.Parse(Console.ReadLine());
            double prices = double.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPrices - 1; i++)
            {
                double numberOfLines = double.Parse(Console.ReadLine());
                double precent = PrecentOfPrices(prices, numberOfLines); bool isSignificantDifference = FindingDiffrance(precent, threshold);

                string message = PrintChanges(numberOfLines, prices, precent, isSignificantDifference);

                Console.WriteLine(message);

                prices = numberOfLines;
            }
        }

        private static string PrintChanges(double firstNumer, double lastNumber, double difrance, bool etherTrueOrFalse)
        {
            string ptrintDiffrances = "";
            if (difrance == 0)
            {
                ptrintDiffrances = string.Format("NO CHANGE: {0}", firstNumer);
            }
            else if (!etherTrueOrFalse)
            {
                ptrintDiffrances = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastNumber, firstNumer, difrance*100);
            }
            else if (etherTrueOrFalse && (difrance > 0))
            {
                ptrintDiffrances = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastNumber, firstNumer, difrance*100);
            }
            else if (etherTrueOrFalse && (difrance < 0))
                ptrintDiffrances = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastNumber, firstNumer, difrance*100);
            return ptrintDiffrances;
        }
        private static bool FindingDiffrance(double threshold, double diffranceOfTreshold)
        {
            if (Math.Abs(threshold) >= diffranceOfTreshold)
            {
                return true;
            }
            return false;
        }

        private static double PrecentOfPrices(double secondNumber, double firstNumber)
        {
            double result = (firstNumber - secondNumber) / secondNumber;
            return result;
        }
    }
}