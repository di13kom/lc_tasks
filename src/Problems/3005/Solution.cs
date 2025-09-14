namespace LeetCode.Problems._3005;

public class Solution
{
    public int MaxFrequencyElements(int[] nums)
    {
        Tuple<int, int> retVal = Tuple.Create(0, 0);
        Dictionary<int, int> dict = [];

        for (int i = 0; i < nums.Length; i++)
        {
            if (!dict.TryAdd(nums[i], 1))
            {
                dict[nums[i]]++;
            }
        }
        foreach (var item in dict)
        {
            if (item.Value > retVal.Item1)
            {
                retVal = Tuple.Create(item.Value, 1);
            }
            else if (item.Value == retVal.Item1)
            {
                retVal = Tuple.Create(item.Value, retVal.Item2 + 1);
            }
        }

        return retVal.Item2 * retVal.Item1;

    }
}