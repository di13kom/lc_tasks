using System.Text;

namespace LeetCode.Problems._3304;

public class Solution
{
    public char KthCharacter(int k)
    {
        StringBuilder sb = new StringBuilder("a");
        StringBuilder newSb = new StringBuilder();

        while (sb.Length < k)
        {
            for (int i = 0; i < sb.Length; i++)
            {
                char newChar = (char)(sb[i] + 1 > 'z' ? 'a' : sb[i] + 1);

                newSb.Append(newChar);
            }
            sb.AppendJoin(string.Empty, newSb);
            newSb.Clear();
        }


        return sb[k - 1];

    }
}