using System;

namespace LeetCode.Problems.DivideAndConquer._1763;

public class Solution1
{
    private const int AsciiLowUpDiff = 32;

    public string LongestNiceSubstring(string s)
    {
        var length = s.Length;
        string retVal = string.Empty;
        HashSet<int> chars = [];

        for (int i = 0; i < length; i++)
        {
            chars.Add(s[i]);
            for (int j = i + 1; j < length; j++)
            {
                chars.Add(s[j]);
                if (IsNiceSubstring(chars))
                {
                    var subString = s[i..(j + 1)];
                    if (subString.Length > retVal.Length)
                        retVal = subString;
                }
            }
            chars.Clear();
        }

        return retVal;
    }

    static bool IsNiceSubstring(HashSet<int> chars)
    {
        foreach (var item in chars)
        {
            if (!chars.Contains(item ^ AsciiLowUpDiff))
                return false;
        }
        return true;
    }
}
