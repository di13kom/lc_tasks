namespace LeetCode.Problems._2962;

public class Solution
{
    public long CountSubarrays(int[] nums, int k)
    {
        var length = nums.Length;
        int maxValue = nums.Max();
        long retVal = 0;
        long matchesByRow = -1;
        int FirstMaxIndex = -1;
        long maxCount = -1;

        for (int i = 0; i < length; i++)
        {
            if (FirstMaxIndex >= i && maxCount >= k)//at least the same sum
            {
                retVal += matchesByRow;
                continue;
            }
            else if (maxCount != -1 && maxCount < k)// no chance to find
            {
                break;
            }
            maxCount = 0;
            matchesByRow = 0;
            FirstMaxIndex = -1;
            for (int j = i; j < length; j++)
            {
                if (nums[j] == maxValue)
                {
                    maxCount++;
                    if (FirstMaxIndex == -1)
                        FirstMaxIndex = j;
                }

                if (maxCount >= k)
                {
                    matchesByRow += length - j;
                    break;
                }
            }
            retVal += matchesByRow;
        }

        return retVal;
    }
}