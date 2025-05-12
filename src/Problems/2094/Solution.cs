
using System.Diagnostics;

namespace LeetCode.Problems._2094;

public class Solution
{
    public int[] FindEvenNumbers(int[] digits)
    {
        SortedSet<int> sortedInts = [];
        int length = digits.Length;

        for (int i = 0; i < length; i++)
        {
            for (int j = i + 1; j < length; j++)
            {
                for (int k = j + 1; k < length; k++)
                {
                    sortedInts.UnionWith(PermuteDigits([digits[i], digits[j], digits[k]]));
                }
            }
        }
        return sortedInts.ToArray();
    }

    private IEnumerable<int> PermuteDigits(List<int> ints)
    {
        Debug.WriteLine("---");
        int digit;
        List<int> retVal = [];
        int intermediateVal;
        for (int i = ints.Count - 1; i >= 0; i--)
        {
            for (int k = i; k >= 0; k--)
            {
                //Permute elements
                //if (i != k)
                //{
                intermediateVal = ints[i];
                ints[i] = ints[k];
                ints[k] = intermediateVal;
                //ints[i] ^= ints[k];
                //ints[k] ^= ints[i];
                //ints[i] ^= ints[k];
                //}

                digit = ints[0] * 100 + ints[1] * 10 + ints[2];

                Debug.WriteLine($"{digit} i:{i} k:{k}");

                if (digit > 100 && digit % 2 == 0)
                {
                    retVal.Add(digit);
                }

                //revert
                /*
                if (i != k)
                {
                    ints[i] ^= ints[k];
                    ints[k] ^= ints[i];
                    ints[i] ^= ints[k];
                }
                */
            }
        }
        Debug.WriteLine("===");


        return retVal;
    }
}
