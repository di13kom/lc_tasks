using System;

namespace LeetCode.Problems.DivideAndConquer._191;

public class Solution
{
    public int HammingWeight(int n)
    {
        int retVal = 0;
        for (int i = 0; i < 32; i++)
        {
            if ((n & 1) == 1)
            {
                retVal++;
            }
            n >>= 1;
        }

        return retVal;
    }
}
