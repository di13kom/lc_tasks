namespace LeetCode.Problems._342;

public class Solution
{
    public bool IsPowerOfFour(int n)
    {
        HashSet<int> ints = [1];
        int digit = 1;

        while (digit > 0)
        {
            digit <<= 2;
            ints.Add(digit);
        }


        return ints.Contains(n);
    }
}