namespace LeetCode.Problems._1010;

public class Solution
{
    public int NumPairsDivisibleBy60(int[] time)
    {
        const int SixtyValue = 60;
        Dictionary<int, int> modulo60songsDict = [];
        int retVal = 0;

        for (int i = 0; i < time.Length; i++)
        {
            if (!modulo60songsDict.TryAdd(time[i] % SixtyValue, 1))
            {
                modulo60songsDict[time[i] % SixtyValue]++;
            }
        }

        for (int i = 0; i < SixtyValue; i++)
        {
            if (!modulo60songsDict.ContainsKey(i))
                continue;
            for (int j = i; j < SixtyValue; j++)
            {
                if (!modulo60songsDict.ContainsKey(j))
                    continue;
                if (i != j && (i + j) % SixtyValue == 0)
                {
                    retVal += modulo60songsDict[i] * modulo60songsDict[j];
                }
                else if (i == j && (i + j) % SixtyValue == 0)
                {
                    retVal += CountSum(modulo60songsDict[i]);
                }

            }
        }

        return retVal;
    }

    private int CountSum(int idx)
    {
        if (idx == 1)
            return 0;
        return idx - 1 + CountSum(idx - 1);
    }
}