using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _1512___NumberOfGoodParis
    {
        public void Execute()
        {
            int[] nums = { 1, 2, 3, 1, 1, 3 };
            int result = NumIdenticalPairs(nums);

            int NumIdenticalPairs(int[] nums)
            {
                int count = 0;

                for (int i = 0; i < nums.Length - 1; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] == nums[j])
                            count++;
                    }
                }
                return count;
            }
        }
        
    }
}
