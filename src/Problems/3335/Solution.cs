using System.Text;

namespace LeetCode.Problems._3335;

public class Solution
{
    private readonly Dictionary<char, string> dict = new()
    {
        //(cc+1) 
        {'a',"ab"}, {'b',"bc"},
        {'c',"cd"}, {'d',"de"},
        {'e',"ef"}, {'f',"fg"},
        {'g',"gh"}, {'h',"hi"},
        {'i',"ij"}, {'j',"jk"},
        {'k',"kl"}, {'l',"lm"},
        {'m',"mn"}, {'n',"no"},
        {'o',"op"}, {'p',"pq"},
        {'q',"qr"}, {'r',"rs"},
        {'s',"st"}, {'t',"tu"},
        {'u',"uv"}, {'v',"vw"},
        {'w',"wx"}, {'x',"xy"},
        {'y',"yz"}, {'z',"zab"},
    };
    static readonly int roundCount = 'z' - 'a' + 1;

    public int LengthAfterTransformations(string s, int t)
    {
        return (int)(Round(new(s), t) % (Math.Pow(10, 9) + 7));
    }

    private int Round(StringBuilder s, int t)
    {
        if (t == 0)
            return s.Length;

        StringBuilder sb = new StringBuilder(s.Length * 2);

        int round;

        if (t > roundCount)
            round = roundCount;
        else
            round = t % roundCount;

        for (int i = 0; i < s.Length; i++)
        {
            char chr = s[i];

            sb.Append(dict[chr]);
        }
        //var newStr = sb.ToString();

        //return Round(newStr.Substring(0, newStr.Length / 2), t - round)
        //       + Round(newStr.Substring(newStr.Length / 2, newStr.Length - newStr.Length / 2), t - round);
        return Round(sb, t - round);
        /*
        int sum = 0;
        foreach (var item in charDict)
        {
            sum += Round(item.Value.ToString(), t - round) * s.Count(x => x == item.Key);
        }
        return sum;
        */
    }
}
