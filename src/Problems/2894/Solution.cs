namespace LeetCode.Problems._2894;

public class Solution
{
    public int DifferenceOfSums(int n, int m)
    {
        int mNonDivisibleSum = 0;
        int mDivisibleSum = 0;

        //List<int> mNonDivisibleRange = [];// = Enumerable.Range(1, n).Where(x => x % m != 0).Sum();

        //List<int> mDivisibleRange = [];// = Enumerable.Range(1, m).Where(x => x %);

        for (int i = 1; i <= n; i++)
        {
            if (i % m == 0)
            {
                mDivisibleSum += i;
                //mDivisibleRange.Add(i);
            }
            else
            {
                mNonDivisibleSum += i;
                //mNonDivisibleRange.Add(i);
            }
        }


        return mNonDivisibleSum - mDivisibleSum ;
    }
}