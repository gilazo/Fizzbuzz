using System;

namespace Carvana.Fizzbuzz
{
    public static class ValuePicker
    {
        public static string PickValue(string number)
        {
            var convertedNumber = Convert.ToInt32(number);
            var isMultipleOfThree = convertedNumber % 3 == 0;
            var isMultipleofFive = convertedNumber % 5 == 0;

            if (isMultipleOfThree)
            {
                return "Fizz";
            }
            if (isMultipleofFive)
            {
                return "Buzz";
            }

            return number;
        }
    }
}
