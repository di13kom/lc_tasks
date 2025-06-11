using System;

namespace LeetCode.Problems._2966;

public class Solution
{
    public int[][] DivideArray(int[] nums, int k)
    {
        const int subArrayLength = 3;
        var Length = nums.Length;
        int[][] retVal = new int[Length / subArrayLength][];
        var orderedNums = nums.Order().ToList();

        for (int i = retVal.Length - 1; i >= 0; i--)
        {
            retVal[i] = new int[subArrayLength];
            for (int j = retVal[i].Length - 1; j >= 0; j--)
            {
                var targetItem = orderedNums.ElementAt(i * subArrayLength + j);
                for (int f = 1; f <= j; f++)
                {
                    var curItem = orderedNums.ElementAt(i * subArrayLength + j - f);
                    if (targetItem - curItem > k)
                    {
                        return [];
                    }
                }
                retVal[i][j] = targetItem;
            }

        }

        return retVal;
    }

}