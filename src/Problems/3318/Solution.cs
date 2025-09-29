namespace LeetCode.Problems._3318;

public class Solution
{
    public int[] FindXSum(int[] nums, int k, int x)
    {
        int length = nums.Length;
        int kLength = length - k + 1;
        int[] retVal = new int[kLength];
        Dictionary<int, int> dict = [];

        for (int i = 0; i < k; i++)
        {
            if (!dict.TryAdd(nums[i], 1))
            {
                dict[nums[i]]++;
            }
        }
        retVal[0] = SumOfX(nums[0..k], dict, x);

        for (int i = 1; i < kLength; i++)
        {
            int prevValue = nums[i - 1];
            int nextValue = nums[i + k - 1];
            dict.TryGetValue(prevValue, out int cnt);
            if (cnt <= 1)
            {
                dict.Remove(prevValue);
            }
            else
            {
                dict[prevValue]--;
            }

            if (!dict.TryAdd(nextValue, 1))
            {
                dict[nextValue]++;
            }

            retVal[i] = SumOfX(nums[i..(i + k)], dict, x);
        }

        return retVal;
    }

    private int SumOfX(int[] ints, IDictionary<int, int> dict, int x)
    {
        int retVal = 0;
        int length = ints.Length;
        int counter = 0;
        SortedDictionary<int, SortedSet<int>> priorityDict = [];

        if (x >= dict.Keys.Count)
            return Enumerable.Sum(ints);

        foreach (var item in dict)
        {
            var key = length - item.Value;
            if (!priorityDict.TryAdd(key, new SortedSet<int>() { item.Key }))
            {
                priorityDict[key].Add(item.Key);
            }
        }


        for (int i = 0; i < x; i++)
        {
            var curValue = priorityDict.ElementAt(i);
            foreach (var item in curValue.Value.Reverse())
            {
                retVal += dict[item] * item;
                if (++counter >= x)
                    return retVal;
            }
        }

        return retVal;
    }
}