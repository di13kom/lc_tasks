namespace LeetCode.Problems._3583;

public class Solution
{
    private const double Modulo = 1e9 + 7;
    public int SpecialTriplets(int[] nums)
    {
        int retVal = 0;
        int length = nums.Length;
        Dictionary<int, List<int>> dict = [];

        for (int i = 0; i < length; i++)
        {
            if (!dict.TryAdd(nums[i], [i]))
            {
                dict[nums[i]].Add(i);
            }
        }
        //Special case
        if (dict.TryGetValue(0, out var zeroLst))
        {
            double zeroCount = zeroLst.Count;
            retVal += (int)(zeroCount * (zeroCount - 1) * (zeroCount - 2) / 6 % Modulo);
        }

        for (int i = 1; i < length; i++)
        {
            if (nums[i] == 0)
                continue;
            var item = nums[i];
            double vl;
            if (dict.TryGetValue(item * 2, out var lst))
            {
                var idx = lst.BinarySearch(i);
                var realIdx = idx >= 0 ? idx : ~idx;
                if (realIdx >= lst.Count)
                    continue;
                if (lst[realIdx] == i)
                {
                    vl = (realIdx - 1 + 1) * (lst.Count - realIdx - 1) % Modulo;
                }
                else
                {
                    vl = (realIdx - 1 + 1) * (lst.Count - realIdx) % Modulo;
                }
                retVal = (int)(((retVal % Modulo) + (vl % Modulo)) % Modulo);
            }
        }

        return retVal;
    }
}