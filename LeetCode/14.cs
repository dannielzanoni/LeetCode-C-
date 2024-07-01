using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _14
    {
        public void Execute()
        {
            string[] strsArray = { "flower", "flow", "flight" };
            string result = LongestCommonPrefix(strsArray);

            string LongestCommonPrefix(string[] strs)
            {
                if(strs == null || strs.Length == 0)
                {
                    return "";
                }
                int minLenght = strs[0].Length;
                foreach(string str in strs)
                {
                    if(str.Length < minLenght) 
                        minLenght = str.Length;
                }

                int i; 
                for(i = 0; i < minLenght; i++) 
                {
                    char currentChar = strs[0][i];
                    foreach (string str in strs)
                    {
                        if (str[i] != currentChar)
                            return strs[0].Substring(0, i);
                    }
                }

                return strs[0].Substring(0, i);
            }
        }
    }
}
