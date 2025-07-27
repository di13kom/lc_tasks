using System.ComponentModel;

namespace LeetCode.Problems._1695;

public class Solution
{
    public int MaximumUniqueSubarray(int[] nums)
    {
        int length = nums.Length;
        int retVal = 0;

        int leftIdx = 0;
        int rightIdx = 0;

        if (length == 1)
            return nums[0];

        int curSum = nums[0];
        HashSet<int> ints = [nums[0]];

        while (++rightIdx < length)
        {
            if (ints.Contains(nums[rightIdx]))
            {
                retVal = Math.Max(retVal, curSum);

                while (leftIdx < rightIdx)
                {
                    curSum -= nums[leftIdx];
                    ints.Remove(nums[leftIdx]);
                    if (nums[leftIdx++] == nums[rightIdx])
                        break;
                }
            }
            ints.Add(nums[rightIdx]);
            curSum += nums[rightIdx];
        }

        return Math.Max(retVal, curSum);
    }
}