using Xunit;

namespace Carvana.Fizzbuzz.Tests
{
    public class ValuePickerTests
    {

        [Fact]
        public void Picker_ValueIsMultipleOfThreeAndFive_FizzBuzzPicked()
        {
            var pickedValue = ValuePicker.PickValue("15");
            Assert.True("Fizz Buzz".Equals(pickedValue));
        }
        [Fact]
        public void Picker_ValueIsMultipleOfThree_FizzPicked()
        {
            var pickedValue = ValuePicker.PickValue("3");
            Assert.True("Fizz".Equals(pickedValue));
        }
        
        [Fact]
        public void Picker_ValueIsMultipleOfFive_BuzzPicked()
        {
            var pickedValue = ValuePicker.PickValue("5");
            Assert.True("Buzz".Equals(pickedValue));

        }

        [Fact]
        public void Picker_ValueIsNotMultipleOfThreeOrMultipleOf5_NumberIsPicked()
        {
            const string value = "8";
            var pickedValue = ValuePicker.PickValue(value);
            Assert.True(value.Equals(pickedValue));
        }
    }        
}
   