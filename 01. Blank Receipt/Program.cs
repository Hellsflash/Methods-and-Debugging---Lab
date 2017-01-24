using System;


namespace _01.Blank_Receipt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PrintReceiptTop();
            PrintReceiptMiddle();
            PrintReceiptBottom();
        
        }

        public static void PrintReceiptTop()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        public static void PrintReceiptMiddle()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        public static void PrintReceiptBottom()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        }
    }
}

