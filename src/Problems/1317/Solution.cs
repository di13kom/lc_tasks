namespace LeetCode.Problems._1317;

public class Solution
{
    public int[] GetNoZeroIntegers(int n)
    {
        int[] retVal = new int[2];
        for (int i = 1; i < n; i++)
        {
            var curValue = n - i;
            if (!IsDigitContainsZero(i) && !IsDigitContainsZero(curValue))
            {
                retVal[0] = i;
                retVal[1] = curValue;
                break;
            }
        }
        return retVal;
    }

    private bool IsDigitContainsZero(int n)
    {
        while (n > 0)
        {
            if (n % 10 == 0)
                return true;
            n /= 10;
        }
        return false;
    }
}