namespace LeetCode.Problems._70;

public class Solution
{
    public int ClimbStairs(int n)
    {
        return MakeStep(0, n);
    }

    private int MakeStep(int steps, int totalSteps)
    {
        if (steps == totalSteps)
        {
            return 1;
        }
        else if (steps > totalSteps)
        {
            return 0;
        }
        return (((steps + 1) <= totalSteps)? MakeStep(steps + 1, totalSteps) : 0)
                + (((steps + 2) <= totalSteps)? MakeStep(steps + 2, totalSteps) : 0);
    }
}