namespace LeetCode.Problems._2099;

public class Solution2
{
    public int[] MaxSubsequence(int[] nums, int k)
    {
        int[] retVal = new int[k];
        int kminValue = int.MaxValue, kMaxValue = int.MinValue;
        var length = nums.Length;

        for (int i = 0; i < length; i++)
        {
            if (kMaxValue <= nums[i])
            {

            }
            else if (kminValue > nums[i])
            {

            }
        }
        return retVal.ToArray();
        /*
        {
            List<int> retVal = [];
            var length = nums.Length;
            var order = nums.Select((x, ind) => new { value = x, index = ind })
                            .OrderBy(x => x.index)
                            .ThenBy(x => x.value)
                            .Skip(length - k)
                            .Take(k)
                            .ToDictionary(x => x.index);

            for (int i = 0; i < length; i++)
            {
                if (order.ContainsKey(i))
                {
                    retVal.Add(nums[i]);
                }
            }
            return retVal.ToArray();
        }
        */
    }
}