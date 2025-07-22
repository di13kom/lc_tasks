
namespace LeetCode.Problems._202;

public class Solution
{
    public bool IsHappy(int n)
    {
        HashSet<int> intsHash = [];
        return TraverseNumber(n, intsHash);
    }

    private bool TraverseNumber(int n, HashSet<int> intsHash)
    {
        if (n == 1)
            return true;
        if (!intsHash.Add(n))
            return false;

        var intArray = ParseIntToArray(n);


        return TraverseNumber(GenerateInt(intArray), intsHash);
    }

    private int[] ParseIntToArray(int n)
    {
        Stack<int> retVal = [];

        while (n > 0)
        {
            retVal.Push(n % 10);
            n /= 10;
        }

        return retVal.ToArray();
    }

    private int GenerateInt(int[] n)
    {
        int retVal = 0;
        for (int i = 0; i < n.Length; i++)
        {
            retVal += n[i] * n[i];
        }

        return retVal;
    }
}
