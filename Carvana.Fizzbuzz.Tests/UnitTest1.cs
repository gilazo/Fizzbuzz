using Xunit;

using Carvana.Fizzbuzz;
namespace Carvana.Fizzbuzz.Tests
{
    public class UnitTest1
    {
        
        [Fact]
        public void MainTest()
        {
           

            var Pick = Program.PickValue(6);

            Assert.Equal(Pick , "Fizz");
          
            
        }
    }
}
