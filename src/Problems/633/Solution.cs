namespace LeetCode.Problems._633;

public class Solution
{
    public bool JudgeSquareSum(int c)
    {
        int[] values;
        int maxValue;

        maxValue = (int)Math.Sqrt(c);
        values = Enumerable.Range(0, maxValue + 1).ToArray();


        return Traverse(values, 0, c);
    }

    private bool Traverse(int[] ints, int idx, int target)
    {
        var x = ints[idx];
        long vl = (long)Math.Pow(x, 2);
        double doubleValue = Math.Sqrt(target - vl);
        if (double.IsNaN(doubleValue))
        {
            return false;
        }
        int intgerValue = (int)doubleValue;
        if (doubleValue - intgerValue == 0)
        {
            return true;
        }
        if (idx == ints.Length - 1)
        {
            return false;
        }

        return Traverse(ints, idx + 1, target);
    }

}