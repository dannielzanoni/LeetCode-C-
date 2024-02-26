using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _557___ReverseWordsInStringlll
    {
        public void Execute()
        {
            string s = "Let's take LeetCode contest";
            string result = ReverseWords(s);

            string ReverseWords(string s)
            {
                char[] chars = s.ToCharArray();
                StringBuilder resultBuilder = new StringBuilder();
                StringBuilder currentWordBuilder = new StringBuilder();

                for (int i = 0; i < s.Length; i++)
                {
                    if (chars[i] != ' ')
                    {
                        currentWordBuilder.Append(chars[i]);
                    }
                    else
                    {
                        if (currentWordBuilder.Length > 0)
                        {
                            resultBuilder.Append(ReverseString(currentWordBuilder.ToString())).Append(' ');
                            currentWordBuilder.Clear();
                        }
                    }
                }

                if (currentWordBuilder.Length > 0)
                {
                    resultBuilder.Append(ReverseString(currentWordBuilder.ToString())).Append(' ');
                }
                return resultBuilder.ToString().Trim();
            }

            static string ReverseString(string s)
            {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }
        }
    }
}
