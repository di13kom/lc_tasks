namespace LeetCode.Problems._136;

public class Solution
{
    public int SingleNumber(int[] nums)
    {
        int retVal = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            retVal ^= nums[i];
        }

        return retVal;
    }
}