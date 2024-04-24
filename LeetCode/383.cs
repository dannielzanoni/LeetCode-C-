using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _383
    {
        public void Execute()
        {
            string ransomNote = "aab";
            string magazine = "baa";
            bool result = CanConstruct(ransomNote, magazine);

            bool CanConstruct(string ransomNote, string magazine)
            {
                Dictionary<char, int> magazineCount = new Dictionary<char, int>();

                foreach (char letter in magazine)
                {
                    if (!magazineCount.ContainsKey(letter))
                        magazineCount[letter] = 0;
                    magazineCount[letter]++;
                }
                foreach (char letter in ransomNote)
                {
                    if (!magazineCount.ContainsKey(letter) || magazineCount[letter] == 0)
                        return false;
                    magazineCount[letter]--;
                }

                return true;
            }
        }
    }
}
