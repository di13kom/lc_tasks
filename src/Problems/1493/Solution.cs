namespace LeetCode.Problems._1493;

public class Solution
{
    const int NonStartedArrayMark = -1;
    const int NoZeroInArrayMark = 0;
    public int LongestSubarray(int[] nums)
    {
        int retVal = 0;
        int curArrayStart = NonStartedArrayMark;
        int nextArrayStart = NonStartedArrayMark;
        int zerosCount = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                if (curArrayStart == NonStartedArrayMark)
                {
                    curArrayStart = i;
                }
                else if (i > 0 && nums[i - 1] == 0)
                {
                    nextArrayStart = i;
                }
            }
            else
            {
                if (curArrayStart != NonStartedArrayMark)
                {
                    if (zerosCount == NoZeroInArrayMark)
                    {
                        retVal = Math.Max(retVal, i - curArrayStart);
                        zerosCount++;
                    }
                    else
                    {
                        retVal = Math.Max(retVal, i - curArrayStart - zerosCount);
                        if (nextArrayStart == NonStartedArrayMark)
                        {
                            curArrayStart = NonStartedArrayMark;
                            zerosCount = NoZeroInArrayMark;
                        }
                        else
                        {
                            curArrayStart = nextArrayStart;
                            nextArrayStart = NonStartedArrayMark;
                            zerosCount = 1;
                        }
                    }
                }
            }
        }
        if (nums.Last() == 1)
        {
            int zeroToAppend;
            if (zerosCount == 0)
            {
                if (curArrayStart > 0 && nums[curArrayStart - 1] == 0)
                    zeroToAppend = 0;
                else
                    zeroToAppend = 1;
            }
            else
            {
                zeroToAppend = zerosCount;
            }

            retVal = Math.Max(retVal, nums.Length - curArrayStart - zeroToAppend);
        }

        return retVal;
    }
}