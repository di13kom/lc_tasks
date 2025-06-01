using System;

namespace LeetCode.Problems._9;

public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
            return false;

        var str = x.ToString();
        var length = str.Length;

        for (int i = 0; i < length / 2; i++)
        {
            if (str[i] != str[length - 1 - i])
                return false;
        }

        return true;
    }
}