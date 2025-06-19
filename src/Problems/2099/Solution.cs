namespace LeetCode.Problems._2099;

public class Solution
{
    public int[] MaxSubsequence(int[] nums, int k)
    {
        List<int> retVal = [];
        var length = nums.Length;
        var order = nums.Order().Skip(length - k).Take(k).ToList();

        for (int i = 0; i < length; i++)
        {
            if (order.Contains(nums[i]) && retVal.Count < k)
            {
                retVal.Add(nums[i]);
                order.Remove(nums[i]);
            }
        }
        return retVal.ToArray();
    }
}