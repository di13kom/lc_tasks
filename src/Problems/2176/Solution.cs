using System;

namespace LeetCode.Problems._2176;

public class Solution
{
    public int CountPairs(int[] nums, int k)
    {
        int retVal = 0;
        Dictionary<int, List<int>> dict = [];

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            var vl = nums[i];

            if (!dict.TryAdd(vl, [i]))
            {
                retVal += dict[vl].Count(x => x * i % k == 0);
                dict[vl].Add(i);
            }
        }

        return retVal;
    }
}