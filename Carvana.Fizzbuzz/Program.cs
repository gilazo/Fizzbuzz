using System;

namespace Carvana.Fizzbuzz
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("I dare you to enter in a number!");
           int number = Convert.ToInt32(Console.ReadLine());
            var value = PickValue(number);
            Console.WriteLine(value);
            Console.ReadLine();
        }

        public static string PickValue(int number)
        {
            int remainder = number % 3;
            if (remainder == 0)
            {
                return "Fizz";
            }
            else
            {
               return number.ToString();
            }

        }

    }
}
