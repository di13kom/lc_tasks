using System.Diagnostics;
using System.Text;

namespace LeetCode.Problems._3335;

public class Solution1
{
    /*
    private readonly Dictionary<char, string> dict = new()
    {
        {'a',"ab"},
        {'b',"bc"},
        {'c',"cd"},//(cc+1)
        {'d',"de"},
    };
    Dictionary<char, int> charDict = [];
    */
    static int roundCount = 'z' - 'a' + 1;

    public int LengthAfterTransformations(string s, int t)
    {
        int retVal;
        StringBuilder sb = new StringBuilder(s);

        if (t > roundCount)
        {
            int cnt = t / roundCount;
            for (int i = roundCount; i < t; i += roundCount)
            {
                Debug.WriteLine($"Start {i}");
                sb = Round(sb, roundCount);
                Debug.WriteLine($"End {i}");
            }
        }
        var moduloCnt = t % roundCount;
        sb = Round(sb, moduloCnt);


        retVal = (int)(sb.Length % (Math.Pow(10, 9) + 7));

        return retVal;
    }

    private StringBuilder Round(StringBuilder s, int vl)
    {
        StringBuilder sb = new StringBuilder(s.Length * 2);

        Dictionary<char, string> charDict = [];

        for (int i = 0; i < s.Length; i++)
        {
            char chr = s[i];
            int nStr = chr + vl;
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

        return sb;
    }
}
