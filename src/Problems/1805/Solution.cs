using System.Text;

namespace LeetCode.Problems._1805;

public class Solution
{
    public int NumDifferentIntegers(string word)
    {
        StringBuilder curDigit = new StringBuilder();
        HashSet<string> ints = [];
        for (int i = 0; i <= word.Length; i++)
        {
            if (i < word.Length && word[i] >= '0' && word[i] <= '9')
            {
                curDigit.Append(word[i]);
            }
            else if (curDigit.Length > 0)
            {
                ints.Add(RemoveLeadingZeros(curDigit));
                curDigit.Clear();
            }
        }
        return ints.Count();
    }

    string RemoveLeadingZeros(StringBuilder sb)
    {
        int f = 0;
        while (sb.Length > f && sb[f] == '0')
        {
            f++;
        }
        sb = sb.Remove(0, f);

        return sb.Length > 0 ? sb.ToString() : "0";
    }
}