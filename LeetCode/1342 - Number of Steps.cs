using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _1342___Number_of_Steps
    {
        public void Execute()
        {
            int num = 14;
            int result = NumberOfSteps(num);

            //Step 1) 14 is even; divide by 2 and obtain 7.
            //Step 2) 7 is odd; subtract 1 and obtain 6.
            //Step 3) 6 is even; divide by 2 and obtain 3.
            //Step 4) 3 is odd; subtract 1 and obtain 2.
            //Step 5) 2 is even; divide by 2 and obtain 1.
            //Step 6) 1 is odd; subtract 1 and obtain 0.

            int NumberOfSteps(int num)
            {
                int steps = -1;
                while (num >= 0)
                {
                    steps++;
                    if (num == 0)
                        return steps;

                    if (num % 2 == 0)
                        num = num / 2;
                    
                    else
                        num -= 1;
                }
                return 0;
            }
        }
    }
}
