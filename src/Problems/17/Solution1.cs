using System;
using System.Text;

namespace LeetCode.Problems._17;

public class Solution1
{
    Dictionary<char, List<char>> dict = new Dictionary<char, List<char>>
        {
            {'2',['a','b','c'] },
            {'3',['d','e','f'] },
            {'4',['g','h','i'] },
            {'5',['j','k','l'] },
            {'6',['m','n','o'] },
            {'7',['p','q','r','s'] },
            {'8',['t','u','v'] },
            {'9',['w','x','y','z'] },
        };
    public IList<string> LetterCombinations(string digits)
    {
        IList<string> retVal = [];
        StringBuilder sb = new StringBuilder();
        if (string.IsNullOrWhiteSpace(digits))
            return [];

        TraceDigits(digits, 0, retVal, sb);

        return retVal;
    }

    private void TraceDigits(string digits, int idx, IList<string> retVal, StringBuilder sb)
    {
        if (idx >= digits.Length)
        {
            retVal.Add(sb.ToString());
            return;
        }

        for (int i = 0; i < dict[digits[idx]].Count; i++)
        {
            sb.Append(dict[digits[idx]].ElementAt(i));
            TraceDigits(digits, idx + 1, retVal, sb);
            sb.Remove(idx, sb.Length - idx);
        }
    }
}
