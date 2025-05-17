using System.Diagnostics;

namespace LeetCode.Problems._1007;

public class Solution
{
    public int MinDominoRotations(int[] tops, int[] bottoms)
    {
        int[] results = new int[4];
        results[0] = TraverseLine(tops, bottoms, 0, tops[0]);
        results[1] = TraverseLine(bottoms, tops, 0, tops[0]);
        results[2] = TraverseLine(tops, bottoms, 0, bottoms[0]);
        results[3] = TraverseLine(bottoms, tops, 0, bottoms[0]);

        return results.Any(x => x >= 0) ? results.Where(x => x >= 0).Min() : -1;
    }

    private int TraverseLine(int[] targetArray, int[] adjacentArray, int position, int targetValue)
    {
        int curVal;
        if (targetArray[position] == targetValue)
            curVal = 0;
        else if (adjacentArray[position] == targetValue)
        {
            Debug.WriteLine($"Replace at {position}, 0-{targetValue}, targetArrayValue:{targetArray[position]}, adjacentArray:{adjacentArray[position]}");
            curVal = 1;
        }
        else
            return int.MinValue;


        if (position >= targetArray.Length - 1)
            return curVal;
        else
            return curVal + TraverseLine(targetArray, adjacentArray, position + 1, targetValue);

    }
}