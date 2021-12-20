using System;
using Xunit;

namespace CleancodeTDDLab1
{
    public class StringCalculaotrAddTest
    {
        [Fact]
        public void Return0()
        {
            var calculator = new StringCalculator();

            var result = calculator.Add("");

        }
        [Theory]
        [InlineData("1", 1)]
        [InlineData("2", 2)]
        public void ReturnString(string numbers, int expectedResult)
        {
            var calculator = new StringCalculator();

            var result = calculator.Add(numbers);

            Assert.Equal(expectedResult, result);
        }
    }
}
