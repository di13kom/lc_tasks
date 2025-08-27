namespace LeetCode.Problems._594;

public class Solution1
{
    public int FindLHS(int[] nums)
    {
        var length = nums.Length;
        int retVal = 0;
        Dictionary<int, int> dict = [];
        for (int i = 0; i < length; i++)
        {
            if (!dict.TryAdd(nums[i], 1))
            {
                dict[nums[i]]++;
            }
        }
        foreach (var item in dict)
        {
            if (dict.ContainsKey(item.Key - 1))
            {
                retVal = Math.Max(retVal, item.Value + dict[item.Key - 1]);
            }

        }
        return retVal;
    }
}
