namespace LeetCode.Problems._70;

public class Solution1
{
    public int ClimbStairs(int n)
    {
        int retVal = 0;
        int stairNum = 0;
        int prevStair = 1;
        int p;
        while (stairNum++ <= n)
        {
            p = retVal;
            retVal += prevStair;
            prevStair = p;
        }

        return retVal;
    }
}
