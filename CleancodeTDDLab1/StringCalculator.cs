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

            var delimiters = new List<char> { ',', '\n'};

            string numberString = numbers;

            if (numberString.StartsWith("//"))
            {
                var splitInput = numberString.Split('\n');
                var newDelimiter = splitInput.First().Trim('/');

                //if (numberString[2] == '[')
                //{

                //}

                numberString = String.Join('\n', splitInput.Skip(1));
                delimiters.Add(Convert.ToChar(newDelimiter));
            }
            
           
            var numberList = numberString.Split(delimiters.ToArray()).Select(str => int.Parse(str));

            var negatives = numberList.Where(n => n < 0);

            if (negatives.Any())
            {
                string negativeString = String.Join(',', negatives.Select(n => n.ToString()));

                throw new Exception($"Negatives not allowed {negativeString}");
            }

            var result = numberList.Where(n => n <= 1000).Sum();


            //var result = numberList.Where(x => Char.IsDigit(x).ToString());

            //String test = numbers;
            //char[] chars = test.ToCharArray();
            //StringBuilder sb = new StringBuilder();
            //foreach (char c in chars)
            //{
            //    if (Char.IsDigit(c))
            //    {
            //        sb.Append(c);
            //    }
            //}

            //result = Int32.Parse(test);


            return result;
        }
    }
}
