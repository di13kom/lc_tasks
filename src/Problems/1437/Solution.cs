namespace LeetCode.Problems._1437;

public class Solution
{
    public bool KLengthApart(int[] nums, int k)
    {
        const int InitialIdx = -1;
        var length = nums.Length;
        int prevOneIdx = InitialIdx;

        for (int i = 0; i < length; i++)
        {
            if (nums[i] == 1)
            {
                if (prevOneIdx == InitialIdx)
                {
                    prevOneIdx = i;
                }
                else
                {
                    if (i - prevOneIdx <= k)
                        return false;
                    prevOneIdx = i;
                }

            }
        }

        return true;
    }
}