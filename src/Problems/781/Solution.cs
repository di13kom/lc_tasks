using System;

namespace LeetCode.Problems._781;

public class Solution
{
    public int NumRabbits(int[] answers)
    {
        int retVal = 0;
        Dictionary<int, int> dict = [];

        foreach (var item in answers)
        {
            if (!dict.TryAdd(item, 1))
            {
                dict[item]++;
            }
        }

        foreach (var item in dict)
        {
            double targetCount = item.Key + 1;

            double curVal = item.Value / targetCount;

            retVal += (int)Math.Ceiling(curVal) * (int)targetCount;
        }


        return retVal;
    }
}
