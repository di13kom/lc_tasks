namespace LeetCode.Problems._3;

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        if (string.IsNullOrEmpty(s))
            return 0;
        var curChar = s[0];
        var maxNonRepeat = 0;
        Dictionary<char, int> nonRepeatDict = new() { { curChar, 0 } };
        for (int i = 1; i < s.Length; i++)
        {
            curChar = s[i];
            if (!nonRepeatDict.TryAdd(curChar, i))
            {
                maxNonRepeat = nonRepeatDict.Count > maxNonRepeat ? nonRepeatDict.Count : maxNonRepeat;
                var clearPosition = nonRepeatDict[curChar];
                var mergeDict = nonRepeatDict.Where(x => x.Value > clearPosition);
                nonRepeatDict = new(mergeDict)
                {
                    { curChar, i }
                };
            }
        }
        return nonRepeatDict.Count > maxNonRepeat ? nonRepeatDict.Count : maxNonRepeat;
    }
}
