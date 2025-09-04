namespace LeetCode.Problems._3516;

public class Solution
{
    public int FindClosest(int x, int y, int z)
    {
        int retVal;

        int xzDistance = Math.Abs(x - z);
        int yzDistance = Math.Abs(y - z);

        if (xzDistance < yzDistance)
            retVal = 1;
        else if (yzDistance < xzDistance)
            retVal = 2;
        else
            retVal = 0;

        return retVal;
    }
}