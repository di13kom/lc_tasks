using System.Text;

namespace LeetCode.Problems._2785;

public class Solution
{
    private readonly Dictionary<char, int> vowelsDict = new() { { 'A', 0 }, { 'E', 0 }, { 'I', 0 }, { 'O', 0 }, { 'U', 0 }, { 'a', 0 }, { 'e', 0 }, { 'i', 0 }, { 'o', 0 }, { 'u', 0 } };
    private const char tokenToReplace = '_';
    public string SortVowels(string s)
    {
        StringBuilder retVal = new StringBuilder(s);
        var length = s.Length;
        for (int i = 0; i < length; i++)
        {
            if (vowelsDict.ContainsKey(s[i]))
            {
                retVal[i] = tokenToReplace;
                vowelsDict[s[i]]++;
            }
        }
        for (int i = 0; i < length; i++)
        {
            if (retVal[i] == tokenToReplace)
            {
                foreach (var item in vowelsDict)
                {
                    if (item.Value > 0)
                    {
                        retVal[i] = item.Key;
                        vowelsDict[item.Key]--;
                        break;
                    }
                }
            }
        }

        return retVal.ToString();
    }
}