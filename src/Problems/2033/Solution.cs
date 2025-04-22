namespace LeetCode.Problems._2033;

public class Solution
{

    public int MinOperations(int[][] grid, int x)
    {
        int retVal = 0;
        List<int> retValues = [];
        Dictionary<int, int> availableSums = [];

        var arr = grid.SelectMany(x => x).Order();

        var elem = arr.ElementAt(arr.Count() / 2);


        foreach (var item in arr)
        {
            var curVal = item;
            if (Math.Abs(curVal - elem) % x > 0)
                return -1;
            retVal += Math.Abs(curVal - elem) / x;
        }

        return retVal;
    }

}
