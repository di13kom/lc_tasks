namespace LeetCode.Problems._2140;

public class Solution2
{
    public long MostPoints(int[][] questions)
    {
        Dictionary<int, List<long>> dict = [];
        int nxtIdx = 0;
        for (int i = 0; i < questions.Length; i++)
        {
            List<long>? lst;
            if (dict.TryGetValue(i, out lst))
            {
                dict.Remove(i);
            }
            else
            {
                lst = [0];
            }
            for (int j = 0; j < lst.Count; j++)
            {
                lst[j] += questions[i][0];
            }
            nxtIdx = questions[i][1] + i + 1;
            if (!dict.TryAdd(nxtIdx, lst))
            {
                dict[nxtIdx].AddRange(lst);
            }
        }

        var lsts = dict.Values.SelectMany(x => x);
        return lsts.Max();
    }
}
