namespace LeetCode.Problems._485;

public class Solution
{
    const int NonStartedArrayMark = -1;
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int retVal = 0;
        int curArrayStart = NonStartedArrayMark;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                if (curArrayStart == NonStartedArrayMark)
                {
                    curArrayStart = i;
                }
            }
            else
            {
                if (curArrayStart != NonStartedArrayMark)
                {
                    retVal = Math.Max(retVal, i - curArrayStart);
                    curArrayStart = NonStartedArrayMark;
                }
            }
        }
        if (nums.Last() == 1)
            retVal = Math.Max(retVal, nums.Length - curArrayStart);
        return retVal;
    }
}