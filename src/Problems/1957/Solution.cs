using System.Text;

namespace LeetCode.Problems._1957;

public class Solution
{
    public string MakeFancyString(string s)
    {
        var length = s.Length;
        StringBuilder retVal = new StringBuilder();

        var prevChar = s[0];
        var consecutiveCharCount = 1;
        retVal.Append(s[0]);
        for (int i = 1; i < length; i++)
        {
            if (prevChar == s[i])
            {
                if (++consecutiveCharCount > 2)
                    continue;
            }
            else
            {
                prevChar = s[i];
                consecutiveCharCount = 1;
            }
            retVal.Append(s[i]);
        }
        return retVal.ToString();
    }
}