using System;

namespace LeetCode.Problems.DivideAndConquer._169;

public class Solution
{
    public int MajorityElement(int[] nums)
    {
        Dictionary<int, int> ints = [];

        foreach (var item in nums)
        {
            if (ints.ContainsKey(item))
            {
                ints[item] += 1;
            }
            else
            {
                ints.Add(item, 1);
            }
        }

        return ints.OrderByDescending(x => x.Value).First().Key;

    }
}
