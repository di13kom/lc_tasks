namespace LeetCode.Problems._633;

public class Solution1
{
    public bool JudgeSquareSum(int c)
    {
        int[] values;
        int maxValue;

        if (c == 0)
            return true;

        maxValue = (int)Math.Sqrt(c);
        values = Enumerable.Range(1, maxValue + 1).ToArray();


        return Traverse(values, c);
    }

    private bool Traverse(int[] ints, int target)
    {
        if (ints.Length == 0)
            return false;
        var middleIndex = ints.Length / 2;
        var multiply = ints[middleIndex] * ints[middleIndex];
        if (ints[middleIndex] <= Math.Sqrt(target))
        {
            var doubleValue = Math.Sqrt(target - multiply);
            if (double.IsNaN(doubleValue))
            {
                return false;
            }
            int intgerValue = (int)doubleValue;
            if (doubleValue - intgerValue == 0)
            {
                return true;
            }
            if (ints.Length == 1)
            {
                return false;
            }
            return Traverse(ints[middleIndex..], target);
        }
        return Traverse(ints[0..middleIndex], target);
    }

}
