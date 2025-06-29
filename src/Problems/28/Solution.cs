namespace LeetCode.Problems._28;

public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        int matchCount = 0;
        int needleMatchIndex = 0;
        int needleMatchLength = needle.Length;

        if (needleMatchLength > haystack.Length)
            return -1;

        for (int i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] == needle[0])
            {
                for (int j = i; j < haystack.Length && j < i + needleMatchLength; j++)
                {
                    if (haystack[j] != needle[needleMatchIndex++])
                    {
                        needleMatchIndex = 0;
                        matchCount = 0;
                        break;
                    }
                    matchCount++;
                }
                if (matchCount == needleMatchLength)
                    return i;
            }
        }
        return -1;
    }
}