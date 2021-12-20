using System;
using Xunit;

namespace CleancodeTDDLab1
{
    public class StringCalculaotrAddTest
    {
        [Fact]
        public void Test1()
        {
            var calculator = new StringCalculator();

            var result = calculator.Add("");

        }
    }
}
