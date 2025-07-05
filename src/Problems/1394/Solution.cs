namespace LeetCode.Problems._1394;

public class Solution
{
    public int FindLucky(int[] arr)
    {
        int retVal = -1;
        Dictionary<int, int> ints = [];
        for (int i = 0; i < arr.Length; i++)
        {
            if (!ints.TryAdd(arr[i], 1))
                ints[arr[i]]++;
        }

        foreach (var item in ints)
        {
            retVal = item.Key == item.Value ? Math.Max(item.Key, retVal) : retVal;
        }

        return retVal;
    }
}