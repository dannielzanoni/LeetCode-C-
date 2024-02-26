using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _229___MajorityElementll
    {
        public void Execute()
        {
            int[] case1 = { 3, 2, 3 };
            IList<int> result = MajorityElement(case1);

            IList<int> MajorityElement(int[] nums)
            {
                IList<int> result = new List<int>();

                if (nums == null || nums.Length == 0)
                {
                    return result;
                }

                int candidate1 = 0, candidate2 = 0, count1 = 0, count2 = 0;

                foreach (int num in nums)
                {
                    if (num == candidate1)
                        count1++;
                    else if (num == candidate2)
                        count2++;
                    else if (count1 == 0)
                    {
                        candidate1 = num;
                        count1 = 1;
                    }
                    else if (count2 == 0)
                    {
                        candidate2 = num;
                        count2 = 1;
                    }
                    else
                    {
                        count1--;
                        count2--;
                    }
                }

                count1 = 0;
                count2 = 0;

                foreach (int num in nums)
                {
                    if (num == candidate1)
                        count1++;
                    else if (num == candidate2)
                        count2++;
                }

                int n = nums.Length;

                if (count1 > n / 3)
                    result.Add(candidate1);

                if (count2 > n / 3 && candidate1 != candidate2)
                    result.Add(candidate2);

                return result;
            }
        }
    }
}
