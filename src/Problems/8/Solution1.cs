namespace LeetCode.Problems._8;

public class Solution1
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

        var intStr = MyAtoiInternal(s[ind..]);
        for (int i = intStr.Length - 1; i >= 0; i--)
        {
            if (retVal + (intStr[i] - '0') * Math.Pow(10, intStr.Length - 1 - i) > int.MaxValue)
            {
                return IsNegativeInt ? int.MinValue : int.MaxValue;
            }
            retVal += (int)((intStr[i] - '0') * Math.Pow(10, intStr.Length - 1 - i));
        }

        return IsNegativeInt ? retVal * -1 : retVal;
    }

    public string MyAtoiInternal(string s)
    {
        if (s.Length == 0 || s[0] < '0' || s[0] > '9')
        {
            return string.Empty;
        }
        return string.Concat(s[0], MyAtoiInternal(s[1..]));
    }
}