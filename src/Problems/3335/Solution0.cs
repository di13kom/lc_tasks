using System.Text;

namespace LeetCode.Problems._3335;

public class Solution0
{
    static readonly int roundCount = 'z' - 'a' + 1;

    public int LengthAfterTransformations(string s, int t)
    {
        return (int)(Round(s, t) % (Math.Pow(10, 9) + 7));
    }

    private int Round(string s, int t)
    {
        if (t == 0)
            return s.Length;

        StringBuilder sb = new StringBuilder(s.Length * 2);

        Dictionary<char, string> charDict = [];
        int round;

        if (t > roundCount)
            round = roundCount;
        else
            round = t % roundCount;

        for (int i = 0; i < s.Length; i++)
        {
            char chr = s[i];
            int nStr = chr + round;
            string str;

            if (!charDict.TryGetValue(chr, out string? value))
            {
                if (nStr == 148)
                {
                    str = "zab";
                }
                else if (nStr > 'z')
                {
                    nStr = nStr % 'z' + ('a' - 1);

                    str = $"{(char)nStr}{(char)(nStr + 1)}";
                }
                else
                {
                    str = $"{(char)nStr}";
                }
                charDict[chr] = str;
            }
            else
            {
                str = value;
            }

            sb.Append(str);
        }
        var newStr = sb.ToString();

        return Round(newStr.Substring(0, newStr.Length / 2), t - round)
               + Round(newStr.Substring(newStr.Length / 2, newStr.Length - newStr.Length / 2), t - round);
    }
}
