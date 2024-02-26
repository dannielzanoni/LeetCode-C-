using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _20___ValidParentheses
    {
        public void Execute()
        {
            string s = "()";
            bool result = IsValid(s);

            bool IsValid(string s)
            {
                HashSet<char> charOpen = new HashSet<char> { '(', '[', '{' };
                HashSet<char> charClose = new HashSet<char> { ')', ']', '}' };

                Stack<char> stack = new Stack<char>();

                for (int i = 0; i < s.Length; i++)
                {
                    char currentChar = s[i];

                    if (charOpen.Contains(currentChar))
                    {
                        stack.Push(currentChar);
                    }
                    else if (charClose.Contains(currentChar))
                    {
                        if (stack.Count == 0 || !IsMatchingPair(stack.Pop(), currentChar))
                        {
                            return false;
                        }
                    }
                }

                return stack.Count == 0;
            }

            bool IsMatchingPair(char open, char close)
            {
                return (open == '(' && close == ')') || (open == '[' && close == ']') || (open == '{' && close == '}');
            }
        }
    }
}
