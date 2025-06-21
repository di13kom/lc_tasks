using System.Collections.Frozen;
using System.Text;

namespace LeetCode.Problems._1061;

public class Solution
{
    public string SmallestEquivalentString(string s1, string s2, string baseStr)
    {
        var length = s1.Length;
        StringBuilder retVal = new StringBuilder();
        Dictionary<char, HashSet<char>> dict = [];
        List<char> chars = [];

        for (int i = 0; i < length; i++)
        {
            if (dict.ContainsKey(s1[i]) && dict.ContainsKey(s2[i]))
            {
                var hs = dict[s1[i]].ToList();
                var hs2 = dict[s2[i]].ToList();
                hs.Add(s1[i]);
                hs.Add(s2[i]);
                hs.AddRange(hs2);
                foreach (var item in hs)
                {
                    dict[item].UnionWith(hs);
                }
            }
            else if (dict.ContainsKey(s1[i]))
            {
                var hs = dict[s1[i]].ToList();
                foreach (var item in hs)
                {
                    dict[item].Add(s2[i]);
                    dict[item].Add(s1[i]);
                }
                if (s1[i] != s2[i])
                    dict.Add(s2[i], [.. dict[s1[i]].ToList()]);

            }
            else if (dict.ContainsKey(s2[i]))
            {
                var hs = dict[s2[i]].ToList();
                foreach (var item in hs)
                {
                    dict[item].Add(s2[i]);
                    dict[item].Add(s1[i]);
                }
                if (s1[i] != s2[i])
                    dict.Add(s1[i], [.. dict[s2[i]].ToList()]);
            }
            else
            {
                chars = [s1[i], s2[i]];
                dict.Add(s1[i], [.. chars]);
                if (s1[i] != s2[i])
                    dict.Add(s2[i], [.. chars]);
            }
        }

        foreach (var chr in baseStr)
        {
            retVal.Append(GetMin(chr, dict));
        }
        return retVal.ToString();
    }

    private char GetMin(char chr, Dictionary<char, HashSet<char>> dict)
    {
        char retVal;
        if (dict.TryGetValue(chr, out HashSet<char>? value))
        {
            retVal = value.Min();
        }
        else
            retVal = chr;

        return retVal;
    }
}