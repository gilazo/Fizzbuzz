using Xunit;

namespace Carvana.Fizzbuzz.Tests
{
    public class ValuePickerTests
    {
        [Fact]
        public void Picker_ValueIsMultipleOfThree_FizzPicked()
        {
            var pickedValue = ValuePicker.PickValue("3");
            Assert.True("Fizz".Equals(pickedValue));
        }

        [Fact]
        public void Picker_ValueIsNotMultipleOfThree_NumberIsPicked()
        {
            const string value = "10";
            var pickedValue = ValuePicker.PickValue(value);
            Assert.True(value.Equals(pickedValue));
        }
    }
}
