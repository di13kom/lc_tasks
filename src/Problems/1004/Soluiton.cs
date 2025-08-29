using System.ComponentModel.DataAnnotations;

namespace LeetCode.Problems._1004;

public class Solution
{
    public int LongestOnes(int[] nums, int k)
    {
        int retVal = 0;
        int zerosCount = 0;
        int leftBound = 0;
        int rightBound = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                if (++zerosCount > k)
                {
                    retVal = Math.Max(retVal, rightBound - leftBound);
                    while (zerosCount > k && leftBound <= rightBound)
                    {
                        zerosCount -= nums[leftBound] == 0 ? 1 : 0;
                        leftBound++;
                    }

                }
            }
            rightBound++;
        }
        retVal = Math.Max(retVal, rightBound - leftBound);

        return retVal;
    }
}