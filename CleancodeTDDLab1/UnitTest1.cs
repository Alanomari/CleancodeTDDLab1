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

        
    }
}
