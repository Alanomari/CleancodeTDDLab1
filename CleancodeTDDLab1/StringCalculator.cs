﻿using System;
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

            return int.Parse(numbers);
        }
    }
}
