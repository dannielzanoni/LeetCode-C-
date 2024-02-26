using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _2038___RemovedColored
    {
        public void Execute()
        {
            string colors = "AAABABB";
            bool result = WinnerOfGame(colors);

            bool WinnerOfGame(string colors)
            {
                int alice = 0, bob = 0;

                for (int i = 1; i < colors.Length - 1; i++)
                {
                    if (colors[i - 1] == colors[i] && colors[i] == colors[i + 1])
                    {
                        if (colors[i] == 'A')
                        {
                            alice += 1;
                        }
                        else if (colors[i] == 'B')
                        {
                            bob += 1;
                        }
                    }
                }
                return alice > bob;
            }
        }
    }
}
