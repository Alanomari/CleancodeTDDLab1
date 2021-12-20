using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleancodeTDDLab1
{
   public class StringCalculator
    {
      public int Add(string numbers)
        {
            if(String.IsNullOrEmpty(numbers))
            return 0;

            var delimiters = new[] { ',', '\n' };

            var result = numbers.Split(delimiters).Select(str => int.Parse(str)).Sum();

            return result;
        }
    }
}
