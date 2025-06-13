using System;

namespace LeetCode.Problems._2294;

public class Solution1
{
    public int PartitionArray(int[] nums, int k)
    {
        int retVal = 0;
        var idx = 0;

        var orderedNums = nums.Distinct().Order();

        if (k == 0)
            return orderedNums.Count();

        while (idx <= orderedNums.Count() - 1)
        {
            if (orderedNums.ElementAt(orderedNums.Count() - 1) - orderedNums.ElementAt(idx) <= k)
                return ++retVal;
            idx = BinarySearch(orderedNums.Count() - 1, idx, orderedNums, k + orderedNums.ElementAt(idx));
            retVal++;
        }

        return retVal;
    }

    private int BinarySearch(int MaxValueArrayIdx, int minValueArrayIdx, IEnumerable<int> orderedNums, int targetValue)
    {
        var middleCnt = ((MaxValueArrayIdx - minValueArrayIdx) / 2) + minValueArrayIdx;
        if (orderedNums.ElementAt(middleCnt) <= targetValue)
        {
            if (orderedNums.ElementAt(middleCnt + 1) > targetValue)
                return middleCnt + 1;
            minValueArrayIdx = middleCnt;
        }
        else
        {
            if (orderedNums.ElementAt(middleCnt - 1) <= targetValue)
                return middleCnt;
            MaxValueArrayIdx = middleCnt;
        }

        return BinarySearch(MaxValueArrayIdx, minValueArrayIdx, orderedNums, targetValue);
    }

}
