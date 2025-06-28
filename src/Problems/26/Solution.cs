namespace LeetCode.Problems._26;

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        Dictionary<int, int> dict = [];
        int curIndex = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            dict.TryAdd(nums[i], i);
        }

        foreach (var item in dict.Keys.Order())
        {
            nums[curIndex++] = item;
        }

        return dict.Count;
    }
}