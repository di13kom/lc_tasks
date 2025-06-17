using System.Text;

namespace LeetCode.Problems._2311;

public class Solution
{
    public int LongestSubsequence(string s, int k)
    {
        int actCnt = 0;
        //char[] chars = s.ToArray();//Debug
        var kBin = Convert.ToString(k, 2);
        var length = s.Length;

        if (s.Length == 1)
            return 1;

        int leftOneIndex = FindMostLeftOne(s.AsSpan());

        while (length - leftOneIndex + actCnt > kBin.Length)
        {
            //chars[leftOneIndex] = 'x';
            length--;
            leftOneIndex = FindMostLeftOne(s.AsSpan(), leftOneIndex + 1);
            actCnt++;
        }
        //Maybe bad decision.
        if (length - leftOneIndex + actCnt == kBin.Length && Convert.ToInt32(s[leftOneIndex..], 2) > k)
            length--;

        //var str = new string(chars);
        return length;
    }

    private int FindMostLeftOne(ReadOnlySpan<char> chr, int startPosition = 0)
    {
        int ind = startPosition;
        while (ind < chr.Length)
        {
            if (chr[ind] == '1')
                return ind;
            ind++;
        }

        return ind;
    }
}