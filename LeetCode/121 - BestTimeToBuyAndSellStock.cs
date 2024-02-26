using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _121_BestTimetoBuyAndSellStock
    {
        public void Execute()
        {
            int[] prices = { 7, 1, 5, 3, 6, 4 };
            int result = MaxProfit(prices);

            int MaxProfit(int[] prices)
            {
                int lowValue = int.MaxValue;
                int highDiff = 0;

                for (int i = 0; i < prices.Length; i++)
                {
                    lowValue = Math.Min(lowValue, prices[i]);

                    int actualDiff = prices[i] - lowValue;

                    highDiff = Math.Max(highDiff, actualDiff);
                }
                return highDiff;
            }
        }
    }
}
