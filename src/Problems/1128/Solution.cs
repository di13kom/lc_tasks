namespace LeetCode.Problems._1128;

public class Solution
{
    public int NumEquivDominoPairs(int[][] dominoes)
    {
        int retVal = 0;

        Dictionary<int, List<int>> dict = [];

        for (int i = 0; i < dominoes.Length; i++)
        {
            int item0 = dominoes[i][0];
            int item1 = dominoes[i][1];
            if (!dict.TryAdd(item0, [i]))
            {
                dict[item0].Add(i);
            }
            if (item0 != item1 && !dict.TryAdd(item1, [i]))
            {
                dict[item1].Add(i);
            }
        }

        for (int i = 0; i < dominoes.Length; i++)
        {
            foreach (var dictItem in dict[dominoes[i][0]])
            {
                if (dictItem > i)
                {
                    retVal += IsDominoesEqual(dominoes[i], dominoes[dictItem]) ? 1 : 0;
                }
            }
        }

        return retVal;

    }

    private bool IsDominoesEqual(int[] domino0, int[] domino1)
    {
        return (domino0[0] == domino1[0] && domino0[1] == domino1[1]) || (domino0[0] == domino1[1] && domino0[1] == domino1[0]);
    }
}