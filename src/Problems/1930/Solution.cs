namespace LeetCode.Problems._1930;

public class Solution
{
    public int CountPalindromicSubsequence(string s)
    {
        var length = s.Length;
        Dictionary<char, (int, int)> dict = [];
        HashSet<string> retVal = [];

        for (int i = 0; i < length; i++)
        {
            if (!dict.TryAdd(s[i], (i, i)))
            {
                if (i - dict[s[i]].Item1 > 1)
                {
                    foreach (var item in dict)
                    {
                        if (i != item.Value.Item2 && i >= item.Value.Item2
                            && (dict[s[i]].Item1 < item.Value.Item2
                                    || dict[s[i]].Item1 < item.Value.Item1))
                        {
                            retVal.Add($"{s[i]}{item.Key}{s[i]}");
                        }
                    }
                }
                dict[s[i]] = (dict[s[i]].Item1, i);
            }

        }

        return retVal.Count;
    }
}