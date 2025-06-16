namespace LeetCode.Problems.DivideAndConquer._1763;

public class Solution
{
    private const int AsciiLowUpDiff = 32;

    public string LongestNiceSubstring(string s)
    {
        var length = s.Length;
        string retVal = string.Empty;
        HashSet<int> upperChars = [];
        HashSet<int> lowerChars = [];

        for (int i = 0; i < length; i++)
        {
            _ = s[i] >= 'a' ? lowerChars.Add(s[i]) : upperChars.Add(s[i]);
            for (int j = i + 1; j < length; j++)
            {
                _ = s[j] >= 'a' ? lowerChars.Add(s[j]) : upperChars.Add(s[j]);
                if (upperChars.Count == lowerChars.Count && IsNiceSubstring(upperChars, lowerChars))
                {
                    if ((j + 1 - i) > retVal.Length)
                        retVal = s[i..(j + 1)];
                }
            }
            upperChars.Clear();
            lowerChars.Clear();
        }

        return retVal;
    }

    static bool IsNiceSubstring(HashSet<int> chars, HashSet<int> lowerChars)
    {
        foreach (var item in chars)
        {
            if (!lowerChars.Contains(item ^ AsciiLowUpDiff))
                return false;
        }
        return true;
    }
}