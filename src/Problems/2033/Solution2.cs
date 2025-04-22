namespace LeetCode.Problems._2033;

public class Solution2
{
    public int MinOperations(int[][] grid, int x)
    {
        List<int> retValues = [];
        Dictionary<int, int> availableSums = [];

        var arr = grid.SelectMany(x => x).Order().ToList();
        int min;
        int max;
        int curVal;
        for (int i = 0, j = arr.Count - 1; i < arr.Count / 2; i++, j--)
        {
            min = arr[i];
            max = arr[j];
            AddValueToDict(availableSums, min);
            while (min < max)
            {
                min += x;
                AddValueToDict(availableSums, min);
            }
            if (min > max)
                return -1;//no common value
        }
        if (availableSums.Count == 0)
            return 0;//no values
        var maxCommon = availableSums.MaxBy(x => x.Value);
        foreach (var item in availableSums.Where(x => x.Value == maxCommon.Value))
        {
            int retVal = 0;
            if (item.Key != 0)
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    curVal = arr[i];
                    //var cnt = Math.Abs(curVal - item.Key) / x;
                    //Debug.WriteLine($"{curVal} = {cnt}");
                    retVal += Math.Abs(curVal - item.Key) / x;
                }
            }
            retValues.Add(retVal);
        }

        return retValues.Min();
    }

    private static void AddValueToDict(Dictionary<int, int> availableSums, int min)
    {
        if (availableSums.TryGetValue(min, out _))
        {
            availableSums[min] += 1;
        }
        else
        {
            availableSums.Add(min, 1);
        }
    }
}
