namespace LeetCode.Problems._217;

public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> ints = [];

        for (int i = 0; i < nums.Length; i++)
        {
            if (!ints.Add(nums[i]))
            {
                return true;
            }
        }

        return false;
    }
}