using System;

namespace Carvana.Fizzbuzz
{
    class Program
    {
        static void Main()
        {
            const string exitValue = "x";

            Console.WriteLine($"Enter {exitValue} to exit.");

            var shouldPromptForInput = true;
            while (shouldPromptForInput)
            {
                Console.Write("Enter a number or exit value: ");
                var input = Console.ReadLine();
                if (input.Equals(exitValue))
                {
                    shouldPromptForInput = false;
                    continue;
                }

                var value = ValuePicker.PickValue(input);
                Console.WriteLine($" {value}");
            }            
        }
    }
}
