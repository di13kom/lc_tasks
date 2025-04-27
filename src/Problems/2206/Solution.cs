using System;

namespace LeetCode.Problems._2206;

public class Solution
{
    public bool DivideArray(int[] nums)
    {
        Dictionary<int, int> dict = [];

        foreach (var item in nums)
        {
            if (!dict.TryAdd(item, 1))
            {
                dict[item] += 1;
            }
        }
        return dict.Values.All(x => x % 2 == 0);
    }
}
