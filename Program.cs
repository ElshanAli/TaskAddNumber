using System;

namespace Task_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int n = number;

            Console.WriteLine(AddNumber(n)); 
           
        }
        public static double AddNumber(int number)
        {
            int n = number;
            int count = 0;
            Console.WriteLine("Enter the number you want to add to the beginning:");
            int m = Convert.ToInt32(Console.ReadLine());
            while (number != 0)
            {
                number /= 10;
                count++;

            }
            double result = (m * (Math.Pow(10, count++)) + n);
            return result;
        }

}
}
