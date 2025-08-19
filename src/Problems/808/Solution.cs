namespace LeetCode.Problems._808;

public class Solution
{
    public double SoupServings(int n)
    {
        Dictionary<KeyValuePair<int, int>, double> dict = [];
        if (n >= 4300) return 1.0;

        int[] soups = [n, n];

        int[][] servingOperations = [[100, 0], [75, 25], [50, 50], [25, 75]];

        return SoupServingsRecursive(soups, servingOperations, 0, dict);
    }

    private double SoupServingsRecursive(int[] soups, int[][] operations, int step, Dictionary<KeyValuePair<int, int>, double> dict)
    {
        var length = operations.Length;
        double[] retVal = new double[length];

        if (soups[0] <= 0 || soups[1] <= 0)
        {
            if (soups[0] <= 0 && soups[1] <= 0)
            {
                return 0.5d;
            }
            if (soups[0] <= 0)
                return 1d;
            if (soups[1] <= 0)
                return 0d;
        }

        for (int i = 0; i < length; i++)
        {
            var newA = soups[0] - operations[i][0];
            var newB = soups[1] - operations[i][1];
            if (dict.TryGetValue(KeyValuePair.Create(newA, newB), out var result))
            {
                retVal[i] = result;
            }
            else
            {
                retVal[i] = SoupServingsRecursive([newA, newB], operations, step + 1, dict);

                if (!dict.TryAdd(KeyValuePair.Create(newA, newB), retVal[i]))
                {
                    Console.WriteLine("Fail");
                }
            }
        }

        return Math.Round(0.25 * retVal.Sum(), 5);
    }
}