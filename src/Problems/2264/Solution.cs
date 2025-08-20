using System.Text;

namespace LeetCode.Problems._2264;

public class Solution
{
    const int MaxLength = 3;
    public string LargestGoodInteger(string num)
    {
        string retVal = string.Empty;
        var length = num.Length;

        StringBuilder curDigit = new StringBuilder();
        curDigit.Append(num[0]);

        for (int i = 1; i < length; i++)
        {
            if (num[i] == num[i - 1])
            {
                curDigit.Append(num[i]);
            }
            else
            {
                retVal = curDigit.Length >= 3 && retVal.FirstOrDefault() < curDigit[0] ? curDigit.ToString(0, MaxLength) : retVal;
                curDigit.Clear();
                curDigit.Append(num[i]);
            }

        }
        retVal = curDigit.Length >= 3 && retVal.FirstOrDefault() < curDigit[0] ? curDigit.ToString(0, MaxLength) : retVal;

        return retVal;
    }
}