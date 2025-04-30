namespace LeetCode.Problems._2537;

public class BadSolution
{
    public long CountGood(int[] nums, int k)
    {
        Dictionary<double, List<double>> dict = [];
        long retVal = 0;
        List<KeyValuePair<double, double>> subArrays = [];
        for (int i = 0; i < nums.Length; i++)
        {
            int item = nums[i];
            List<List<int>> newElemList = [];
            if (!dict.TryAdd(item, [i]))
            {
                dict[item].Add(i);
            }
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (j - i >= 0)
                    subArrays.Add(new KeyValuePair<double, double>(i, j));
            }
        }

        foreach (var item in subArrays)
        {
            var total = 0;
            foreach (var targetValue in dict.Where(c => c.Value.Count >= 2))
            {
                total += targetValue.Value.Count(x => x >= item.Key && x <= item.Value) * 2;
            }
            retVal += total >= k ? 1 : 0;
        }

        return retVal;
        //return CountSubArray(nums, nums.Length, k);
    }
}
