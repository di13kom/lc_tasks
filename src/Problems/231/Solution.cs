namespace LeetCode.Problems._231;

public class Solution
{
    public bool IsPowerOfTwo(int n)
    {
        if (n == 1)
            return true;
        if (n <= 0)
            return false;

        do
        {
            if ((n & 1) == 1)
            {
                return false;
            }
            n >>= 1;
        }
        while (n > 1);
        return true;

    }
}