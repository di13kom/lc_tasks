namespace LeetCode.Problems._1403;

public class Solution
{
    public IList<int> MinSubsequence(int[] nums)
    {

        Array.Sort(nums);
        var sum = nums.Sum();
        IList<int> retVal = [nums.Last()];
        var curSum = nums.Last();

        for (int i = nums.Length - 2; i >= 0; i--)
        {
            if (curSum > (sum - curSum))
            {
                return retVal;
            }
            curSum += nums[i];
            retVal.Add(nums[i]);
        }

        return retVal;
    }
}