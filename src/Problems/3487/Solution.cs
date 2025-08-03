namespace LeetCode.Problems._3487;

public class Solution
{
    public int MaxSum(int[] nums)
    {
        Array.Sort(nums);

        if (nums.Last() < 0)
            return nums.Last();

        int retVal = nums[0] >= 0 ? nums[0] : 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1] && nums[i] >= 0)
            {
                retVal += nums[i];
            }
        }
        return retVal;
    }
}