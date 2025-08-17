namespace LeetCode.Problems._97;

public class Solution
{
    public bool IsInterleave(string s1, string s2, string s3)
    {
        if (s3.Length != s1.Length + s2.Length)
            return false;
        if (s3.LastOrDefault() != s2.LastOrDefault() && s3.LastOrDefault() != s1.LastOrDefault())
            return false;
        Dictionary<char, int> s3Dict = StringToDictionary(s3);
        Dictionary<char, int> s1S2Dict = StringToDictionary(string.Concat(s1, s2));

        foreach (var item in s1S2Dict)//Not optimal solution
        {
            if (!s3Dict.TryGetValue(item.Key, out var value) || value != item.Value)
                return false;
        }



        return IsInterleave_recursive(s1, s2, s3);
    }

    private Dictionary<char, int> StringToDictionary(ReadOnlySpan<char> chars)
    {
        Dictionary<char, int> retVal = [];

        foreach (var item in chars)
        {
            if (!retVal.TryAdd(item, 1))
            {
                retVal[item]++;
            }
        }
        return retVal;
    }

    private bool IsInterleave_recursive(ReadOnlySpan<char> s1, ReadOnlySpan<char> s2, ReadOnlySpan<char> s3)
    {
        bool retVal = false;

        if (s1.Length == 0 && s2.Length == 0 && s3.Length == 0)
        {
            return true;
        }

        if (s1.Length > 0 && s3.Length > 0 && s1[0] == s3[0])
        {
            retVal = IsInterleave_recursive(s1[1..], s2[..], s3[1..]);
        }
        if (!retVal && s2.Length > 0 && s3.Length > 0 && s2[0] == s3[0])
        {
            retVal = IsInterleave_recursive(s1[..], s2[1..], s3[1..]);
        }

        return retVal;
    }
}