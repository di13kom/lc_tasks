namespace LeetCode.Problems._2094;

public class Solution2
{
    public int[] FindEvenNumbers(int[] digits)
    {
        List<int> sortedInts = [];

        Dictionary<int, int> dict = [];
        int goodIter = 0;
        foreach (var item in digits)
        {
            if (!dict.TryAdd(item, 1))
            {
                dict[item]++;
            }
        }

        Dictionary<int, int> compareDict = [];
        for (int i = 100; i < 1000; i += 2)
        {
            var curVal = i;
            compareDict.Clear();
            for (int j = 1; j <= 3; j++)
            {
                int vl = curVal % 10;
                curVal /= 10;
                if (!compareDict.TryAdd(vl, 1))
                {
                    compareDict[vl]++;
                }
            }

            goodIter = 0;
            foreach (var dictItem in compareDict)
            {
                if (dict.TryGetValue(dictItem.Key, out int length) && length >= dictItem.Value)
                {
                    goodIter++;
                }
            }
            if (goodIter == compareDict.Keys.Count)
                sortedInts.Add(i);
        }
        return sortedInts.ToArray();
    }
}