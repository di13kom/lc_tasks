namespace LeetCode.Problems._66;

public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        var length = digits.Length;
        for (int i = length - 1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i]++;
                return digits;
            }
            else
            {
                digits[i] = 0;
            }
        }
        return new List<int>(digits).Prepend(1).ToArray();
    }
}