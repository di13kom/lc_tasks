using System;

namespace LeetCode.Problems._1295;

public class Solution
{
    public int FindNumbers(int[] nums)
    {
        int evenCount = 0;
        int iter;

        for (int i = 0; i < nums.Length; i++)
        {
            iter = 0;
            int item = nums[i];
            do
            {
                item /= 10;
                iter++;
            }
            while (item > 0);

            evenCount += iter % 2 == 0 ? 1 : 0;
        }
        return evenCount;
    }
}