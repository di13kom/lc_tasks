namespace LeetCode.Problems._2348;

public class Solution
{
    const int ZeroInteger = 0;
    public long ZeroFilledSubarray(int[] nums)
    {
        var length = nums.Length;
        long retVal = 0;
        long consecutiveZero = 0;

        for (int i = 0; i < length; i++)
        {
            if (nums[i] == ZeroInteger)
            {
                consecutiveZero++;
            }
            else
            {
                retVal += TotalSubArraysOutConsecutiveArray(consecutiveZero);
                consecutiveZero = 0;
            }
        }
        retVal += TotalSubArraysOutConsecutiveArray(consecutiveZero);

        return retVal;
    }

    private long TotalSubArraysOutConsecutiveArray(long vl) => vl * (vl + 1) / 2;

}