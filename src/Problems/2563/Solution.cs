namespace LeetCode.Problems._2563;

public class Solution
{
    public long CountFairPairs(int[] nums, int lower, int upper)
    {
        long retVal = 0;
        if (nums.Length < 1)
            return 0;

        Array.Sort(nums);

        return LowerUpperBound(nums, upper + 1) - LowerUpperBound(nums, lower);
    }

    private long LowerUpperBound(int[] nums, int targetValue)
    {
        int lower = 0;
        int upper = nums.Length - 1;
        long retVal = 0;
        while (lower <= upper)
        {
            int sum = nums[lower] + nums[upper];
            if (sum < targetValue)
            {
                retVal += upper - lower;
                lower++;
            }
            else
            {
                upper--;
            }

        }

        return retVal;
    }
}
