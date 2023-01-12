using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskProject4
{
    internal class NumberTasks
    {
        internal int ReverseNumber(int number)
        {
            int reverseNumber = 0, r;
            int countDigit = (int)Math.Log10(number);

            while (number != 0)
            {
                r = number % 10;
                number /= 10;
                reverseNumber += r * (int)Math.Pow(10, countDigit--);
            }

            return reverseNumber;

        }

    }
}
