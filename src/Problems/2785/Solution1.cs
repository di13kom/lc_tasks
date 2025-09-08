using System.Text;

namespace LeetCode.Problems._2785;

public class Solution1
{
    private readonly HashSet<char> vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U',];
    private const char tokenToReplace = '_';
    public string SortVowels(string s)
    {
        StringBuilder retVal = new StringBuilder(s);
        List<char> vowelList = [];
        var length = s.Length;
        for (int i = 0; i < length; i++)
        {
            if (vowels.Contains(s[i]))
            {
                retVal[i] = tokenToReplace;
                vowelList.Add(s[i]);
            }
        }
        var sorted = vowelList.Order();
        int sortedIndx = 0;

        for (int i = 0; i < length; i++)
        {
            if (retVal[i] == tokenToReplace)
            {
                retVal[i] = sorted.ElementAt(sortedIndx++);
            }
        }

        return retVal.ToString();
    }
}