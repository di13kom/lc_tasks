using System.Text;

namespace LeetCode.Problems._395;

public class Solution
{
    public int LongestSubstring(string s, int k)
    {
        return LongestSubstringInternal(s, k).Length;
    }
    public string LongestSubstringInternal(string s, int k)
    {
        string retVal = string.Empty;
        StringBuilder curString = new StringBuilder();
        int subStringStatus = -1;
        Dictionary<char, List<int>> dict = [];
        Dictionary<char, int> backTrack = [];
        for (int i = 0; i < s.Length; i++)
        {
            if (!dict.TryAdd(s[i], [i]))
            {
                dict[s[i]].Add(i);
            }
        }

        for (int i = 0; i < s.Length; i++)
        {
            char chr = s[i];
            if (dict[chr].Count >= k)
            {
                if (subStringStatus == -1)
                {
                    if (IsKString(backTrack, k, curString) && curString.Length > retVal.Length)
                    {
                        retVal = curString.ToString();
                    }
                    backTrack.Clear();
                    curString.Clear();
                    subStringStatus = 0;
                    curString.Append(chr);
                    if (!backTrack.TryAdd(chr, 1))
                    {
                        backTrack[chr]++;
                    }
                }
                else if (subStringStatus == 0)
                {
                    curString.Append(chr);
                    if (!backTrack.TryAdd(chr, 1))
                    {
                        backTrack[chr]++;
                    }
                }
            }
            else
            {
                subStringStatus = -1;
            }
        }

        return (IsKString(backTrack, k, curString) && curString.Length > retVal.Length) ? curString.ToString() : retVal;

    }

    bool IsKString(Dictionary<char, int> dict, int k, StringBuilder sb)
    {
        bool IsSubstringRequired = false;
        foreach (var item in dict)
        {
            if (item.Value < k)
            {
                IsSubstringRequired = true;
            }
        }
        if (IsSubstringRequired)
        {
            var nStr = LongestSubstringInternal(sb.ToString(), k);
            sb.Clear();
            sb.Append(nStr);
        }

        return sb.Length > 0 ? true : false;
    }
}