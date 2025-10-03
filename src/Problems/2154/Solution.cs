namespace LeetCode.Problems._2154;

public class Solution
{
    public int FindFinalValue(int[] nums, int original)
    {
        Dictionary<int, int> dict = [];
        int length = nums.Length;

        for (int i = 0; i < length; i++)
        {
            if (!dict.TryAdd(nums[i], 1))
            {
                dict[nums[i]]++;
            }
        }

        while (true)
        {
            if (dict.TryGetValue(original, out int value) && value > 0)
            {

                dict[original] = --value;
                original *= 2;
            }
            else
            {
                return original;
            }
        }
    }
}