﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public String IsFizzOrBuzz(int num)
        {
            var solution = "";

            if (num == 1)
            {
                solution = Convert.ToString(num);

            }

            else if (num == 2)
            {
                solution = Convert.ToString(num);

            }

            else if (num % 3 == 0)
            {
                solution = "Fizz";

            }

            else if (num == 4)
            {
                solution = Convert.ToString(num);

            }

            else if (num % 5 == 0)
            {
                solution = "Buzz";

            }

            else if (num % 3 == 0 && num % 5 == 0)
            {
                solution = "FizzBuzz";

            }

            return solution;
        }


    }
}
