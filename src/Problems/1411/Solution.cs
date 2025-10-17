namespace LeetCode.Problems._1411;

public class Solution
{
    private enum Colors
    {
        Red,
        Yellow,
        Green
    }

    /// <summary>
    /// Only two types of coloring ABA,ABC.
    /// </summary>
    /// <remarks>ABA aka `Red|Green|Red`, ABC aka `Red|Green|Yellow`
    private enum FillColorType
    {
        ABA,
        ABC
    }

    readonly List<Dictionary<FillColorType, double>> dp = [];
    private const int ArrayWidth = 3;
    const double ModuloValue = 1E9 + 7;
    public int NumOfWays(int n)
    {
        Colors[] ints = new Colors[3];
        dp.Add(new Dictionary<FillColorType, double> { { FillColorType.ABA, 0 }, { FillColorType.ABC, 0 } });
        _ = CreateFirstLevel(0, 0, ints);//(ABA - 6, ABC - 6)

        //Every ABA type produce 3 ABA + 2 ABC children
        //Every ABC type produce 2 ABA + 2 ABC children
        /*
        ABC ---     ABA ---
        |     |     |     |
        BAB  CAB   BAB  CAC
        BCB        BAC  CAB
        BCA        BCB
        */
        for (int i = 1; i < n; i++)
        {
            dp.Add(new Dictionary<FillColorType, double> { { FillColorType.ABA, 0 }, { FillColorType.ABC, 0 } });
            foreach (var item in dp[i - 1])
            {
                if (item.Key == FillColorType.ABA)
                {
                    dp[i][FillColorType.ABA] = (dp[i][FillColorType.ABA] + (3 * item.Value % ModuloValue) % ModuloValue) % ModuloValue;
                    dp[i][FillColorType.ABC] = (dp[i][FillColorType.ABC] + (2 * item.Value % ModuloValue) % ModuloValue) % ModuloValue;
                }
                else//(item.Key == FillColorType.ABC)
                {
                    dp[i][FillColorType.ABA] = (dp[i][FillColorType.ABA] + (2 * item.Value % ModuloValue) % ModuloValue) % ModuloValue;
                    dp[i][FillColorType.ABC] = (dp[i][FillColorType.ABC] + (2 * item.Value % ModuloValue) % ModuloValue) % ModuloValue;
                }
            }
        }

        return (int)((dp[n - 1][FillColorType.ABA] + dp[n - 1][FillColorType.ABC]) % ModuloValue);
    }
    private int CreateFirstLevel(int idx, int level, Colors[] parent)
    {
        int retVal = 0;

        if (idx == ArrayWidth)
        {
            if (parent[0] == parent[2])
                dp[level][FillColorType.ABA]++;
            else
                dp[level][FillColorType.ABC]++;
            return 1;
        }

        for (int c = 0; c < ArrayWidth; c++)
        {
            if (idx > 0 && c == (int)parent[idx - 1])
                continue;
            parent[idx] = (Colors)c;
            retVal += CreateFirstLevel(idx + 1, level, parent);
        }

        return retVal;
    }
}