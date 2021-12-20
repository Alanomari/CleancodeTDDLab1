using System;
using Xunit;

namespace CleancodeTDDLab1
{
    public class StringCalculaotrAddTest
    {
        public StringCalculator _calculator = new StringCalculator();

      
        [Theory]
        [InlineData("1,2", 3)]
        [InlineData("5,5", 10)]
        [InlineData("5,5,5,5,1", 21)]

        public void ReturnString(string numbers, int expectedResult)
        {
          
            var result = _calculator.Add(numbers);

            Assert.Equal(expectedResult, result);
        }
    }
}
