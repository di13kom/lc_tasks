using System.Text;

namespace LeetCode.Problems._3461;

public class Solution
{
    public bool HasSameDigits(string s)
    {
        StringBuilder sb = new StringBuilder();

        while (true)
        {
            var length = s.Length;
            for (int i = 1; i < length; i++)
            {
                sb.Append((s[i - 1] - '0' + s[i] - '0') % 10);
            }

            if (sb.Length <= 2)
                break;
            s = sb.ToString();
            sb.Clear();
        }


        return sb[0] == sb[1];
    }
}