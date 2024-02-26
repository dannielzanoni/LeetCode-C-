using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _191___NumberOf1Bits
    {   
        public void Execute()
        {
            uint n = 00000000000000000000000000001011;
            int result = HammingWeight(n);

            int HammingWeight(uint n)
            {
                int count = 0;
                string binaryString = Convert.ToString(n, 2);

                for (int i = 0; i < binaryString.Length; i++)
                {
                    char c = binaryString[i];
                    if (c == '1')
                    {
                        count++;
                    }
                }
                return count;
            }
        }
    }
}
