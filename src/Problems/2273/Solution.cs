namespace LeetCode.Problems._2273;

public class Solution
{
    public IList<string> RemoveAnagrams(string[] words)
    {
        var length = words.Length;
        IList<string> retVal = [];

        retVal.Add(words[0]);
        for (int i = 1; i < length; i++)
        {
            if (!IsAnagram(words[i], retVal.Last()))
            {
                retVal.Add(words[i]);
            }
        }
        return retVal;
    }

    private bool IsAnagram(string str0, string str1)
    {
        Dictionary<char, int> chars0 = [];
        Dictionary<char, int> chars1 = [];
        if (str0.Length != str1.Length)
            return false;
        for (int i = 0; i < str0.Length; i++)
        {
            if (!chars0.TryAdd(str0[i], 1))
            {
                chars0[str0[i]]++;
            }
            if (!chars1.TryAdd(str1[i], 1))
            {
                chars1[str1[i]]++;
            }
        }
        foreach (var item in chars0)
        {
            if (!chars1.TryGetValue(item.Key, out int res) || item.Value != res)
                return false;
        }

        return true;
    }
}