namespace LeetCode.Problems._1920;

public class Solution
{
    public int[] BuildArray(int[] nums)
    {
        int[] retVal = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            retVal[i] = nums[nums[i]];
        }

        return retVal;
    }
}