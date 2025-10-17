namespace LeetCode.Problems._961;

public class Solution
{
    public int RepeatedNTimes(int[] nums)
    {

        int length = nums.Length;
        HashSet<int> ints = [];

        for (int i = 0; i < length; i++)
        {
            if (!ints.Add(nums[i]))
            {
                return nums[i];
            }
        }

        return -1;
    }
}