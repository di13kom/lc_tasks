using System;

namespace LeetCode.Problems._1399;

public class Solution
{
    public int CountLargestGroup(int n)
    {
        Dictionary<int, List<int>> dict = [];

        foreach (var item in Enumerable.Range(1, n).Reverse())
        {
            var numTarget = 0;
            double remainder = item;
            var curPower = 1;
            while (remainder >= 1)
            {
                numTarget += (int)(remainder % (int)Math.Pow(10, curPower));
                remainder /= (int)Math.Pow(10, curPower);
            }

            if (!dict.TryAdd(numTarget, [item]))
            {
                dict[numTarget].Add(item);
            }
        }

        var mx = dict.Values.Max(x => x.Count);

        return dict.Values.Count(x => x.Count == mx);
    }
}
