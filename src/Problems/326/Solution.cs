namespace LeetCode.Problems._326;

public class Solution
{
    private const int Three = 3;
    public bool IsPowerOfThree(int n)
    {
        if (n <= 0)
            return false;
        if (n == 1)
            return true;

        return PowerThree(n, Three);

    }

    private bool PowerThree(int n, int curVal)
    {
        if (curVal == n)
            return true;
        if (curVal > n || curVal < 0)
            return false;

        return PowerThree(n, curVal * Three);
    }
}