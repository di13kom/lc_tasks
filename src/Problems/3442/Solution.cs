namespace LeetCode.Problems._3442;

public class Solution
{
    public int MaxDifference(string s)
    {
        int[] values = new int['z' - 'a' + 1];
        int minEven = byte.MaxValue, maxOdd = 0;
        foreach (var item in s)
        {
            values[item - 'a']++;
        }
        foreach (var item in values)
        {
            if (item == 0)
                continue;
            var curValue = item;
            if (item % 2 == 0)
            {
                minEven = minEven > item ? item : minEven;
            }
            else
            {
                maxOdd = maxOdd < item ? item : maxOdd;
            }

        }

        return maxOdd - minEven;

    }
}
