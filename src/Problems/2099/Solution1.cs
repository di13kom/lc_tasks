namespace LeetCode.Problems._2099;

public class Solution1
{
    public int[] MaxSubsequence(int[] nums, int k)
    {
        List<int> retVal = [];
        var length = nums.Length;
        var order = nums.Order().Skip(length - k).Take(k).GroupBy(x => x).ToDictionary(x => x.Key, y => y.Count());

        for (int i = 0; i < length; i++)
        {
            if (order.ContainsKey(nums[i]) && retVal.Count < k)
            {
                retVal.Add(nums[i]);
                order[nums[i]]--;
                if (order[nums[i]] == 0)
                    order.Remove(nums[i]);
            }
        }
        return retVal.ToArray();
    }
}