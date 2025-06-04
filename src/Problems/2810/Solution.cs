using System.Text;

namespace LeetCode.Problems._2810;

public class Solution
{
    public string FinalString(string s)
    {
        StringBuilder retVal = new StringBuilder();

        foreach (var curChar in s)
        {
            if (curChar != 'i')
                retVal.Append(curChar);
            else
                Reverse(retVal);
        }
        return retVal.ToString();

    }

    private void Reverse(StringBuilder sb)
    {
        var length = sb.Length;
        for (int i = 0; i < length / 2; i++)
        {
            var chr = sb[i];
            sb.Replace(sb[i], sb[length - 1 - i], i, 1);
            sb.Replace(sb[length - 1 - i], chr, length - i - 1, 1);
        }
    }
}