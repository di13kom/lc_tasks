namespace LeetCode.Problems._3190;

public class Solution
{
    public int MinimumOperations(int[] nums)
    {
        int retVal = 0;
        int length = nums.Length;

        for (int i = 0; i < length; i++)
        {
            if (nums[i] % 3 > 0)
            {
                retVal++;
            }
        }

        return retVal;
    }
}