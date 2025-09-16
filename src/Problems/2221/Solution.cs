namespace LeetCode.Problems._2221;

public class Solution
{
    public int TriangularSum(int[] nums)
    {
        var length = nums.Length;
        if (length == 1)
            return nums[0];
        int[] ints = new int[length - 1];
        for (int i = 1; i < length; i++)
        {
            ints[i - 1] = (nums[i] + nums[i - 1]) % 10;
        }
        return TriangularSum(ints);
    }
}