namespace LeetCode.Problems._2210;

public class Solution
{
    public int CountHillValley(int[] nums)
    {
        int retVal = 0;
        int closestLeftNonEqualValue = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                if (closestLeftNonEqualValue < nums[i - 1] && nums[i] < nums[i - 1])//num[i-1] - hill
                {
                    retVal++;
                }
                else if (closestLeftNonEqualValue > nums[i - 1] && nums[i] > nums[i - 1])//num[i-1] - valley
                {
                    retVal++;
                }
                closestLeftNonEqualValue = nums[i - 1];
            }
        }

        return retVal;
    }
}