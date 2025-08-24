namespace LeetCode.Problems._2894;

public class Solution
{
    public int DifferenceOfSums(int n, int m)
    {
        int mNonDivisibleSum = 0;
        int mDivisibleSum = 0;

        for (int i = 1; i <= n; i++)
        {
            if (i % m == 0)
            {
                mDivisibleSum += i;
            }
            else
            {
                mNonDivisibleSum += i;
            }
        }


        return mNonDivisibleSum - mDivisibleSum ;
    }
}