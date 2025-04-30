using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LeetCode.Problems._2537;
public class Solution
{
    Dictionary<double, List<double>> dict = [];
    public long CountGood(int[] nums, int k)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            int item = nums[i];
            if (!dict.TryAdd(item, [i]))
            {
                dict[item].Add(i);
            }
        }
        return CountSubArray(nums, 0, k);
    }


    private long CountSubArray(int[] nums, double startIndex, int k)
    {
        long retVal = 0;
        if (startIndex == nums.Length - 2)
            return nums[nums.Length - 1] == nums[nums.Length - 2] && k == 1 ? 1 : 0;

        foreach (KeyValuePair<double, List<double>> item in dict)
        {
            var cnt = item.Value.Count(x => x >= startIndex);
            var pairs = CountFreq(cnt);
            retVal += pairs;
        }

        return (retVal >= k ? 1 : 0) + CountSubArray(nums, ++startIndex, k);
    }

    private long CountFreq(int n)
    {
        if (n < 2)
            return 0;

        return (long)n * (n - 1) / 2;
    }
}
