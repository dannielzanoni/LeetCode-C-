using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _456___132Pattern
    {
        public void Execute()
        {
            int[] nums = { 1, 2, 3, 4 };
            bool result = Find132pattern(nums);

            bool Find132pattern(int[] nums)
            {
                int n = nums.Length;
                int[] minArray = new int[n];

                minArray[0] = nums[0];
                for (int i = 1; i < n; i++)
                {
                    minArray[i] = Math.Min(minArray[i - 1], nums[i]);
                }

                Stack<int> stack = new Stack<int>();

                for (int j = n - 1; j >= 0; j--)
                {
                    while (stack.Count > 0 && stack.Peek() < nums[j])
                    {
                        if (stack.Peek() > minArray[j])
                        {
                            return true;
                        }
                        stack.Pop();
                    }
                    stack.Push(nums[j]);
                }

                return false;
            }
        }
    }
}
