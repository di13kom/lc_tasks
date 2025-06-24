using System.Reflection.Metadata.Ecma335;

namespace LeetCode.Problems._7;

public class Solution
{
    public int Reverse(int x)
    {
        int retVal = 0;
        //int.MaxValue = 2147483647
        //int.MinValue = -2147483648;
        List<int> ints = [];
        bool IsNegativeInt = false;
        if (x < 0)
        {
            IsNegativeInt = true;
            x *= -1;
        }

        while (x > 0)
        {
            ints.Add(x % 10);
            x /= 10;
        }

        for (int i = 0; i < ints.Count; i++)
        {
            retVal += (int)(ints[i] * Math.Pow(10, ints.Count - 1 - i));
        }

        return retVal < 0 ? 0 : (IsNegativeInt ? retVal * -1 : retVal);
    }
}
