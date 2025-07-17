namespace LeetCode.Problems._3201;

public class Solution
{
    private record ParityCountItem(int OddCount, int EvenCount);
    public int MaximumLength(int[] nums)
    {
        var length = nums.Length;
        ParityCountItem[] idxSums = new ParityCountItem[length];
        idxSums[length - 1] = new(1, 1);
        idxSums[length - 2] = ((nums[length - 2] + nums[length - 1]) % 2) > 0 ? new ParityCountItem(2, 1) : new ParityCountItem(1, 2);
        int retVal = 2;

        for (int i = length - 3; i >= 0; i--)
        {
            retVal = Math.Max(retVal, TraverseArray(nums, i, idxSums));
        }

        return retVal;
    }

    private int TraverseArray(int[] nums, int targetIdx, ParityCountItem[] idxSums)
    {
        int oddCount = 1;
        int evenCount = 1;

        //Binary search????
        for (int i = targetIdx + 1; i < nums.Length; i++)
        {
            if ((nums[targetIdx] + nums[i]) % 2 == 0)
            {
                evenCount = Math.Max(evenCount, 1 + idxSums[i].EvenCount);
            }
            else
            {
                oddCount = Math.Max(oddCount, 1 + idxSums[i].OddCount);
            }
        }

        idxSums[targetIdx] = new(oddCount, evenCount);
        return Math.Max(oddCount, evenCount);
    }
}