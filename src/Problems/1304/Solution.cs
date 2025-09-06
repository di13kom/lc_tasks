namespace LeetCode.Problems._1304;

public class Solution
{
    public int[] SumZero(int n)
    {
        int[] retVal = new int[n];
        int count = n / 2;

        for (int i = 0; i < n / 2 * 2; i++)//n/2*2 - leave last odd index with zero.
        {
            if (i % 2 == 0)
            {
                retVal[i] = count;
            }
            else
            {
                retVal[i] = count * -1;
                count--;
            }
        }

        return retVal;
    }
}