using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _125___ValidPalindrome
    {
        public void Execute()
        {
            string s = "A man, a plan, a canal: Panama";
            bool result = IsPalindrome(s);

            bool IsPalindrome(string s)
            {
                int left = 0;
                int right = s.Length - 1;

                while (left < right)
                {
                    char leftChar = s[left];
                    char rightChar = s[right];

                    if (!Char.IsLetterOrDigit(leftChar))
                    {
                        left++;
                    }
                    else if (!Char.IsLetterOrDigit(rightChar))
                    {
                        right--;
                    }
                    else
                    {
                        if (Char.ToLower(leftChar) != Char.ToLower(rightChar))
                        {
                            return false;
                        }
                        left++;
                        right--;
                    }
                }
                return true;
            }
        }
    }
}
