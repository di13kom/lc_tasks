namespace LeetCode.Problems.DivideAndConquer._190;

public class Solution
{
    public uint reverseBits(uint n)
    {
        //string bits = Convert.ToString(n, 2).PadLeft(32, '0');

        if (n == 0)
            return 0;

        int[] array = ToBinaryArray(n);

        var revArray = array.Reverse();

        return BinaryToUint(revArray.ToArray());
    }

    private uint BinaryToUint(int[] revArray)
    {
        uint retVal = 0;

        for (int i = 0; i < 32; i++)
        {
            retVal += (uint)(revArray[i] == 1 ? 1 << i : 0);
        }

        return retVal;
    }

    private int[] ToBinaryArray(uint n)
    {
        double curValue = n;
        int[] ints = new int[32];
        do
        {
            var pw = FindNextPower(curValue);
            ints[pw] = 1;

            curValue -= 1u << pw;

        } while (curValue > 0);

        return ints;
    }

    private int FindNextPower(double targetValue)
    {
        int i = 0;
        uint vl = 0;

        while (true)
        {
            vl = 1u << i;
            if (vl > targetValue || i == 32)
                break;
            i++;
        }

        return --i;
    }
}

