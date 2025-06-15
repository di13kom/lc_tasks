using System;

namespace LeetCode.Problems._2200;

public class Solution1
{
    public IList<int> FindKDistantIndices(int[] nums, int key, int k)
    {
        var length = nums.Length;
        IList<int> retVal = [];
        Dictionary<int, List<int>> dict = [];
        for (int i = 0; i < length; i++)
        {
            if (!dict.TryAdd(nums[i], [i]))
            {
                dict[nums[i]].Add(i);
            }
        }

        foreach (var dictItem in dict)
        {
            foreach (var item in dictItem.Value)
            {
                foreach (var KeyItems in dict[key])
                {
                    if (Math.Abs(item - KeyItems) <= k)
                    {
                        retVal.Add(item);
                        break;
                    }
                }
                
            }
        }

        return retVal.Order().ToList();
    }
}
