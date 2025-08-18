namespace LeetCode.Problems._3363;

public class Solution
{
    public int MaxCollectedFruits(int[][] fruits)
    {
        int retVal;
        var length = fruits[0].Length;

        int[][] usedPathes = new int[length][];
        for (int i = 0; i < length; i++)
        {
            usedPathes[i] = new int[length];
        }

        var dict = fruits.SelectMany(x => x).Order();
        if (dict.First() == 0 && dict.Last() == 0)
            return 0;

        int[] childOneStart = [0, 0];
        int[] childThreeStart = [0, length - 1];
        int[] childTwoStart = [length - 1, 0];

        int[][] childOnePaths = [[1, 1]];
        int[][] childTwoPaths = [[-1, 1], [0, 1], [1, 1]];
        int[][] childThreePaths = [[1, -1], [1, 0], [1, 1]];

        int[] childOnefinalPoint = [length - 1, length - 1];
        int[] childTwofinalPoint = [length - 1, length - 2];
        int[] childThreefinalPoint = [length - 2, length - 1];

        var childOneSum = CollectFruits(fruits, childOneStart, childOnePaths, 0, childOnefinalPoint, usedPathes);
        // Debug.WriteLine("====Second child===");
        var childTwoSum = CollectFruits(fruits, childTwoStart, childTwoPaths, 0, childTwofinalPoint, usedPathes);
        // Debug.WriteLine("====Third child===");
        var childThreeSum = CollectFruits(fruits, childThreeStart, childThreePaths, 0, childThreefinalPoint, usedPathes);

        retVal = childOneSum + childThreeSum + childTwoSum;


        return retVal;
    }

    private int CollectFruits(int[][] fruits, int[] startPosition, int[][] allowedPathes, int currentStep, int[] finalPoint, int[][] usedPathes)
    {
        int retVal = 0;
        var length = fruits[0].Length;
        if (currentStep > length - 1)
            return int.MinValue;
        if (startPosition[0] == finalPoint[0] && startPosition[1] == finalPoint[1])
        {
            usedPathes[finalPoint[0]][finalPoint[1]] = fruits[startPosition[0]][startPosition[1]];
            return fruits[finalPoint[0]][finalPoint[1]];
        }

        for (int i = 0; i < allowedPathes.Length; i++)
        {
            int newX = startPosition[0] + allowedPathes[i][0];
            if (newX > length - 1 || newX < 0)
                continue;
            int newY = startPosition[1] + allowedPathes[i][1];
            if (newY > length - 1 || newY < 0)
                continue;
            if ((startPosition[0] - startPosition[1] < 0 && newX - newY >= 0) || (startPosition[0] - startPosition[1] > 0 && newX - newY <= 0))
                continue;


            if (usedPathes[newX][newY] != 0)
            {
                retVal = Math.Max(retVal, usedPathes[newX][newY]);
                continue;
            }

            int[] newStartPosition = [newX, newY];
            //Debug.WriteLine($"Try with x:{newX} y:{newY} from x:{startPosition[0]} y:{startPosition[1]}");
            retVal = Math.Max(retVal, CollectFruits(fruits, newStartPosition, allowedPathes, currentStep + 1, finalPoint, usedPathes));
        }
        usedPathes[startPosition[0]][startPosition[1]] = fruits[startPosition[0]][startPosition[1]] + retVal;
        return fruits[startPosition[0]][startPosition[1]] + retVal;
    }
}