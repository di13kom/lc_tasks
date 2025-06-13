using System.Diagnostics;

namespace LeetCode.Problems._2294;

public class Solution
{
    public int PartitionArray(int[] nums, int k)
    {
        int retVal = 0;
        int minValueArrayIdx = 0;
        int MaxValueArrayIdxConst = nums.Length - 1;

        Array.Sort(nums);

        for (int idx = 0; idx < nums.Length; idx++)
        {
            if (nums.ElementAt(MaxValueArrayIdxConst) - nums.ElementAt(minValueArrayIdx) <= k)
            {
                idx = MaxValueArrayIdxConst;
            }

            if (nums.ElementAt(idx) - nums.ElementAt(minValueArrayIdx) <= k)
            {

            }
            else
            {
                retVal++;
                minValueArrayIdx = idx;
            }
        }
        if (Enumerable.ElementAt<int>(nums, MaxValueArrayIdxConst) - Enumerable.ElementAt<int>(nums, minValueArrayIdx) <= k)
        {
            retVal++;
        }


        return retVal;
    }
}