using System.Text;

namespace LeetCode.Problems._43;

public class Solution
{
    const char ZeroChar = '0';
    public string Multiply(string num1, string num2)
    {
        StringBuilder retVal = new StringBuilder(new string(ZeroChar, num1.Length + num2.Length));

        if (num1 == "0" || num2 == "0")
            return "0";

        for (int i = num1.Length - 1; i >= 0; i--)
        {
            int iValue = num1.ElementAtOrDefault(i) - ZeroChar;
            for (int j = num2.Length - 1; j >= 0; j--)
            {
                int InsertIndex = (num2.Length + num1.Length - 1) - (num2.Length - 1 - i) - (num1.Length - 1 - j);
                var sbLength = retVal.Length;
                var jValue = (num2.ElementAtOrDefault(j) - ZeroChar) * iValue;

                InsertData(jValue, retVal, ref InsertIndex);
            }
        }
        while (retVal[0] == ZeroChar)
        {
            retVal.Remove(0, 1);
        }


        return retVal.ToString();
    }

    private IEnumerable<int> SplitInteger(int value)
    {
        int currentPower = 1;
        if (value == 0)
        {
            yield return 0;
            yield break;
        }
        while (value > 0)
        {
            yield return (int)(value % Math.Pow(10, currentPower++));
            value /= 10;
        }

    }

    private void InsertData(int digit, StringBuilder sb, ref int idx)
    {
        var d1 = digit + sb[idx] - ZeroChar;
        if (d1 < 10)
        {
            sb[idx] = (char)(d1 + ZeroChar);
            idx--;
            return;
        }
        else
        {
            sb[idx] = ZeroChar;
            digit = d1;
        }
        foreach (var d in SplitInteger(digit))
        {
            InsertData(d, sb, ref idx);
        }
    }
}