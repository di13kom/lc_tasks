namespace LeetCode.Problems._219;

public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        HashSet<int> ints = [];

        if (k == 0)
            return false;

        for (int i = 0; i < nums.Length; i++)
        {
            if (!ints.Add(nums[i]))
            {
                for (int j = i - 1, f = k; j >= 0 && f >= 1; j--, f--)
                {
                    if (nums[i] == nums[j])
                        return true;
                }
            }
        }

        return false;

    }
}