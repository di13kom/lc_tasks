using System;

namespace LeetCode.Problems._9;

public class Solution1
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
            return false;
        int pwr = 0;
        int[] ints = new int[10];

        while (x > 0)
        {
            ints[pwr++] = x % 10;
            x /= 10;
        }

        for (int i = 0; i < pwr - 1; i++)
        {
            if (ints[i] != ints[pwr - 1 - i])
                return false;
        }
        return true;
    }
}
