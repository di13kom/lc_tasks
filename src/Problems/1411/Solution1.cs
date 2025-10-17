namespace LeetCode.Problems._1411;

public class Solution1
{
    private enum Colors
    {
        // Unknown,
        Red,
        Yellow,
        Green
    }

    readonly List<List<Colors[]>> dp = [];
    private const int ArrayWidth = 3;
    const double ModuloValue = 1E9 + 7;
    public int NumOfWays(int n)
    {
        int retVal = 0;
        Colors[] ints = new Colors[3];

        for (int i = 0; i < n; i++)
        {
            retVal = 0;
            dp.Add([]);
            if (i == 0)
            {
                retVal += NumOfWays(0, i, ints);
            }
            else
            {
                foreach (var item in dp[i - 1])
                {
                    retVal += (int)(NumOfWays(0, i, ints, item) % ModuloValue);
                }
            }
        }

        return retVal;
    }
    private int NumOfWays(int idx, int level, Colors[] parent, Colors[]? item = null)
    {
        int retVal = 0;

        if (idx == ArrayWidth)
        {
            Colors[] cp = new Colors[parent.Length];
            Array.Copy(parent, cp, parent.Length);
            dp[level].Add(cp);
            return 1;
        }

        for (int c = 0; c < ArrayWidth; c++)
        {
            if ((idx > 0 && c == (int)parent[idx - 1]) || item?.ElementAt(idx) == (Colors)c)
                continue;
            parent[idx] = (Colors)c;
            retVal += NumOfWays(idx + 1, level, parent, item);
        }

        return retVal;
    }
}