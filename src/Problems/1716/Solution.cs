namespace LeetCode.Problems._1716;

public class Solution
{
    public int TotalMoney(int n)
    {
        const int weekLength = 7;
        int retVal = 0;
        int weekCount = 0;


        for (int i = 1; i <= n; i++)
        {
            if (i % weekLength == 0)
            {
                retVal += weekLength + weekCount++;
            }
            else
            {
                retVal += (i % weekLength) + weekCount;
            }
        }

        return retVal;
    }
}