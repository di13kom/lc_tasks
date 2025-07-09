using System.Text;

namespace LeetCode.Problems._67;

public class Solution
{
    public string AddBinary(string a, string b)
    {
        if (a.Length > b.Length)
        {
            b = string.Concat(new string('0', a.Length - b.Length), b);
        }
        else
        {
            a = string.Concat(new string('0', b.Length - a.Length), a);
        }
        int length = b.Length;

        char[] sb = new char[length];
        char curChar;
        bool isAdditionalRequired = false;
        int curIdx;

        for (curIdx = length - 1; curIdx >= 0; curIdx--)
        {
            if (a[curIdx] == b[curIdx])
            {
                curChar = isAdditionalRequired ? '1' : '0';
                isAdditionalRequired = a[curIdx] == '1';
            }
            else
            {
                curChar = isAdditionalRequired ? '0' : '1';
            }
            sb[curIdx] = curChar;
        }
        if (isAdditionalRequired)
        {
            return string.Concat('1', new string(sb));
        }

        return new string(sb);
    }
}