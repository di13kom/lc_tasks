namespace LeetCode.Problems._763;

public class Solution
{
    Dictionary<char, List<int>> dict = [];
    public IList<int> PartitionLabels(string s)
    {
        IList<int> retVal = [];

        for (int i = 0; i < s.Length; i++)
        {
            if (!dict.TryAdd(s[i], [i]))
            {
                dict[s[i]].Add(i);
            }
        }

        int minIdx = 0;
        int maxIdx = s.Length - 1;
        while (true)
        {
            maxIdx = dict[s[minIdx]].Max();
            GetMaxIdx(s, minIdx, ref maxIdx);
            retVal.Add(maxIdx + 1 - minIdx);
            minIdx = maxIdx + 1;
            if (maxIdx >= s.Length - 1)
                break;
        }

        return retVal;
    }

    private void GetMaxIdx(string s, int minIdx, ref int maxIdx)
    {
        while (true)
        {
            var chrLst = GetCharsInRange(s, minIdx, maxIdx);
            foreach (var chr in chrLst)
            {
                maxIdx = Math.Max(maxIdx, dict[chr].Max());
            }
            if (chrLst.Count == GetCharsInRange(s, minIdx, maxIdx).Count)
                break;
        }
    }

    private IList<char> GetCharsInRange(string s, int startIndex, int finishIndex)
    {
        return s[startIndex..finishIndex].Distinct().Order().ToList();
    }
}
