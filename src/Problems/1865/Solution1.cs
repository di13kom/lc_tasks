namespace LeetCode.Problems._1865;

public class FindSumPairs1
{

    private int[] nums1Lst;
    private int[] nums2Lst;
    readonly Dictionary<int, int> dict = [];

    public FindSumPairs1(int[] nums1, int[] nums2)
    {
        nums1Lst = nums1;
        nums2Lst = nums2;

        for (int idx = 0; idx < nums2Lst.Length; idx++)
        {
            if (!dict.TryAdd(nums2[idx], 1))
            {
                dict[nums2Lst[idx]]++;
            }
        }
    }

    public void Add(int index, int val)
    {
        var prevVal = nums2Lst[index];
        var newVal = val + prevVal;
        nums2Lst[index] = newVal;


        if (!dict.TryAdd(newVal, 1))
        {
            dict[newVal]++;
        }
        if (dict.ContainsKey(prevVal))
        {
            dict[prevVal]--;
        }
    }

    public int Count(int tot)
    {
        int retVal = 0;

        for (int i = 0; i < nums1Lst.Length; i++)
        {
            if (dict.TryGetValue(tot - nums1Lst[i], out var lst))
            {
                retVal += lst;
            }
        }
        return retVal;
    }
}
