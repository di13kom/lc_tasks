namespace LeetCode.Problems._1323;

public class Solution
{
    public int Maximum69Number(int num)
    {
        int retVal = 0;
        const int maxPower = 4;
        int[] ints = new int[maxPower];
        int i = maxPower - 1;

        while (num > 0)
        {
            ints[i--] = num % 10;
            num /= 10;
        }

        for (i = 0; i < maxPower; i++)
        {
            if (ints[i] == 0)
                continue;
            var digit = ints[i];
            ints[i] = ints[i] == 6 ? 9 : 9;
            retVal = Math.Max(retVal, ArrayToInt(ints));

            ints[i] = digit;
        }


        return retVal;

    }

    private int ArrayToInt(int[] ints)
    {
        int retVal = 0;
        int length = ints.Length;
        for (int i = length - 1; i >= 0; i--)
        {
            retVal += (int)(ints[i] * Math.Pow(10, length - 1 - i));
        }

        return retVal;
    }
}