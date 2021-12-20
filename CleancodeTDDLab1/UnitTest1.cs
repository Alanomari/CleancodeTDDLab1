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


        [Theory]
        [InlineData("1\n2,3", 6)]
        public void ReturnStringWithNewLineOrSeparatedNumbers(string numbers, int expectedResult)
        {

            var result = _calculator.Add(numbers);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("//;\n1;2;3", 6)]
        public void ReturnStringWithDifferentDelimiter(string numbers, int expectedResult)
        {

            var result = _calculator.Add(numbers);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("-2, 4", "Negatives not allowed -2")]
        [InlineData("-6, -4", "Negatives not allowed -6,-4")]
        public void ThrowNegativeNumbersExceptionMessage(string numbers, string expectedMessage)
        {
            Action action = () => _calculator.Add(numbers);

            var exception = Assert.Throws<Exception>(action);

            Assert.Equal(expectedMessage, exception.Message);
        }

        [Theory]
        [InlineData("2,1001", 2)]
        [InlineData("1,1001", 1)]
        [InlineData("1000,2", 1002)]
        [InlineData("5,1200", 5)]
        [InlineData("200,200, 4000", 400)]
        public void IgnoreValueOver1000(string numbers, int expectedResult)
        {

            var result = _calculator.Add(numbers);

            Assert.Equal(expectedResult, result);
        }
    }
}
