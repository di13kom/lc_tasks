namespace LeetCode.Problems.PrefixSum._3652;

public class Solution
{
    public long MaxProfit(int[] prices, int[] strategy, int k)
    {
        var length = prices.Length;

        long[] prefixSum = new long[length];
        long lastSumWithK = 0;

        for (int i = 0; i < length; i++)
        {
            var mlt = prices[i] * strategy[i];
            prefixSum[i] = i == 0 ? mlt : mlt + prefixSum[i - 1];
        }
        long retVal = prefixSum[length - 1];

        for (int i = 0; i <= length - k ; i++)
        {
            var sumPost = prefixSum[length - 1] - prefixSum[i + k - 1];
            var sumPre = i == 0 ? 0 : prefixSum[i - 1];
            if (lastSumWithK == 0)
            {
                for (int j = i + k / 2; j < i + k; j++)
                {
                    lastSumWithK += prices[j];
                }
            }
            else
            {
                lastSumWithK -= prices[i + k / 2 - 1];
                lastSumWithK += prices[i + k - 1];
            }
            retVal = Math.Max(retVal, sumPre + lastSumWithK + sumPost);
        }


        return retVal;
    }
}