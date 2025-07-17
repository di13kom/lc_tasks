namespace LeetCode.Problems._3201;

public class Solution1
{
    private class ParityCountItem(int OddEvenCount, int EvenEvenCount, int AlternateCount)
    {
        public int OddEvenCount { get; set; } = OddEvenCount;
        public int EvenEvenCount { get; set; } = EvenEvenCount;
        public int AlternateCount { get; set; } = AlternateCount;
    }
    public int MaximumLength(int[] nums)
    {
        var length = nums.Length;
        ParityCountItem retVal;
        if (((nums[length - 2] + nums[length - 1]) % 2) == 0)
        {
            retVal = ((nums[length - 2] % 2) == 0) ? new ParityCountItem(0, 2, 1) : new ParityCountItem(2, 0, 1);
        }
        else
        {
            retVal = new ParityCountItem(1, 1, 2);
        }

        for (int i = length - 3; i >= 0; i--)
        {
            TraverseArray(nums, i, retVal);
        }

        return Math.Max(Math.Max(retVal.OddEvenCount, retVal.EvenEvenCount), retVal.AlternateCount);
    }

    private void TraverseArray(int[] nums, int targetIdx, ParityCountItem idxSums)
    {
        if ((nums[targetIdx] + nums[targetIdx + 1]) % 2 != 0)
        {
            idxSums.AlternateCount++;
        }
        idxSums.EvenEvenCount += ((nums[targetIdx] % 2) == 0) ? 1 : 0;
        idxSums.OddEvenCount += ((nums[targetIdx] % 2) != 0) ? 1 : 0;
    }
}