using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _896___MonotonicArray
    {
        public void Execute()
        {
            int[] case1 = { 1, 2, 2, 3 };
            bool result = IsMonotonic(case1);

            bool IsMonotonic(int[] nums)
            {
                int monotonicFlag = 0;

                for (int i = 1; i < nums.Length; i++)
                {
                    int cmp = nums[i].CompareTo(nums[i - 1]);

                    if (cmp != 0)
                    {
                        if (cmp != monotonicFlag && monotonicFlag != 0)
                        {
                            return false;
                        }

                        monotonicFlag = cmp;
                    }
                }
                return true;
            }
        }
    }
}
