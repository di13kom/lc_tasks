using System.Net;

namespace LeetCode.Problems._8;

public class Solution
{
    public int MyAtoi(string s)
    {
        int retVal = 0;
        int ind = 0;
        bool IsNegativeInt = false;
        if (string.IsNullOrWhiteSpace(s))
            return 0;
        while (s[ind] == ' ')
        {
            ind++;
        }
        if (s[ind] == '-')
        {
            IsNegativeInt = true;
            ind++;
        }
        else if (s[ind] == '+')
        {
            ind++;
        }

        retVal = MyAtoiInternal(s[ind..], IsNegativeInt ? [int.MinValue] : [int.MaxValue]);

        return retVal;
    }

    public int MyAtoiInternal(string s, List<int> ints)
    {
        if (s.Length == 0 || s[0] < '0' || s[0] > '9')
        {
            int retVal = 0;
            var sign = ints[0] == int.MinValue ? -1 : 1;
            for (int i = ints.Count - 1; i >= 1; i--)
            {
                if ((retVal + ints[i] * Math.Pow(10, ints.Count - 1 - i)) * sign > int.MaxValue)
                {
                    return int.MaxValue;
                }
                else if ((retVal + ints[i] * Math.Pow(10, ints.Count - 1 - i)) * sign < int.MinValue)
                {
                    return int.MinValue;
                }
                else
                    retVal += (int)(ints[i] * Math.Pow(10, ints.Count - 1 - i));
            }
            return retVal * sign;
        }
        ints.Add(s[0] - '0');
        return MyAtoiInternal(s[1..], ints);
    }
}