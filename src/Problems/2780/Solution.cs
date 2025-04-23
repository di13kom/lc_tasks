using System;
using System.ComponentModel.DataAnnotations;

namespace LeetCode.Problems._2780;

public class Solution
{
    public int MinimumIndex(IList<int> nums)
    {
        int retVal = -1;

        int dominantCountLeft = 0;
        var dominantGroup = nums.GroupBy(x => x).OrderByDescending(x => x.Count()).First();
        var dominantNumber = dominantGroup.Key;
        var dominantTotalCount = dominantGroup.Count();
        var length = nums.Count;
        int leftNonDominantCount = 0;
        for (int i = 0; i < length; i++)
        {
            var rightDominant = dominantTotalCount - dominantCountLeft;
            var rightNonDominantDigits = length - leftNonDominantCount - dominantCountLeft - rightDominant;
            if (leftNonDominantCount < dominantCountLeft && rightDominant > rightNonDominantDigits)
            {
                retVal = i - 1;
                break;
            }

            if (nums[i] == dominantNumber)
                dominantCountLeft++;
            else
                leftNonDominantCount++;

        }

        return retVal;
    }
}
