namespace LeetCode.Problems._50;

public class Solution
{
    public double MyPow(double x, int n)
    {
        if (n == 0 || x == 1)
            return 1;
        if (x == -1 && n % 2 == 0)
        {
            return 1;
        }
        else if (x == -1 && n % 2 == 0)
        {
            return -1;
        }
        if (n < -15)
            return 0;
        var pow = n < 0 ? n * -1 : n;
        double retVal;

        retVal = myPower(x, pow);

        return n < 0 ? 1 / retVal : retVal;

    }

    private double myPower(double x, int n)
    {
        if (n == 1)
            return x;

        var vl = myPower(x * x, n / 2);
        if (n % 2 != 0)
            return vl * x;
        else
            return vl;
    }
}