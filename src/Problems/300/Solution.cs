namespace LeetCode.Problems._300;

public class Solution
{
    public int LengthOfLIS(int[] nums)
    {
        var length = nums.Length;
        int[] idxSums = new int[length];
        idxSums[length - 1] = 1;
        int retVal = 1;

        if (length == 1)
            return 1;

        for (int i = length - 2; i >= 0; i--)
        {
            if (nums[i] == nums[i + 1])//Same digits. It means sum is the same.
            {
                idxSums[i] = idxSums[i + 1];
            }
            else
            {
                retVal = Math.Max(retVal, TraverseArray(nums, i, idxSums));
            }
        }

        return retVal;
    }

    private int TraverseArray(int[] nums, int targetIdx, int[] idxSums)
    {
        int retVal = 1;

        //Binary search????
        for (int i = targetIdx + 1; i < nums.Length; i++)
        {
            retVal = Math.Max(retVal, nums[targetIdx] < nums[i] ? 1 + idxSums[i] : 1);
        }

        idxSums[targetIdx] = retVal;
        return retVal;
    }
}