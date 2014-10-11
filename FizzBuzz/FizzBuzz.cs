using System;
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

            if ((num % 3 == 0) && (num % 5 == 0))
            {
                solution = "FizzBuzz";

            }

            else if (num % 3 == 0)
            {
                solution = "Fizz";

            }

            else if (num % 5 == 0)
            {
                solution = "Buzz";

            }

            else 
            {
                solution = Convert.ToString(num);
            }

            return solution;
        }


    }
}
