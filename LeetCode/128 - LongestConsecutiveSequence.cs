using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _128___LongestConsecutive
    {
        public void Execute()
        {
            int[] cas1 = { 100, 4, 200, 1, 3, 2 };
            int result = LongestConsecutive(cas1);

            int LongestConsecutive(int[] nums)
            {
                if (nums.Length == 0)
                    return 0;

                HashSet<int> numSet = new HashSet<int>(nums);
                int longestStreak = 0;

                foreach (int num in numSet)
                {
                    if (!numSet.Contains(num - 1))
                    {
                        int currentNum = num;
                        int currentStreak = 1;

                        while (numSet.Contains(currentNum + 1))
                        {
                            currentNum++;
                            currentStreak++;
                        }

                        longestStreak = Math.Max(longestStreak, currentStreak);
                    }
                }
                return longestStreak;
            }
        }
    }
}
