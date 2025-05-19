namespace LeetCode.Problems._2226;

public class Solution
{
    public int MaximumCandies(int[] candies, long k)
    {
        int retVal = 0;
        SortedDictionary<int, List<int>> dict = [];
        int length = candies.Length;
        int sum = 0;
        int maxCandies = 0;


        for (int i = 0; i < length; i++)
        {
            if (!dict.TryAdd(candies[i], [i]))
            {
                dict[candies[i]].Add(i);
            }
            sum += candies[i];
        }
        if (sum < k)
            return 0;

        foreach (KeyValuePair<int, List<int>> item in dict.Reverse())
        {
            if (item.Value.Count >= k)
                return item.Key;

            maxCandies += item.Value.Count;
            if (maxCandies >= k)
                return item.Key;

        }



        return retVal;
    }
}
