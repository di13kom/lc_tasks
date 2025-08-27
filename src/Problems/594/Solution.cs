namespace LeetCode.Problems._594;

public class Solution
{
    public int FindLHS(int[] nums)
    {
        const int lhsArrayDiff = 1;
        int retVal = 0;
        int firstArrayStart = 0, secondArrayStart = 0;
        Array.Sort(nums);

        for (int i = 1; i < nums.Length; i++)
        {
            var diff = nums[i] - nums[i - 1];
            if (diff > 0)
            {
                if (firstArrayStart < secondArrayStart)
                    retVal = Math.Max(retVal, i - firstArrayStart);
                if (diff == lhsArrayDiff)
                {
                    firstArrayStart = secondArrayStart;
                    secondArrayStart = i;
                }
                else if (diff > lhsArrayDiff)
                {
                    firstArrayStart = i;
                    secondArrayStart = i;
                }
            }
        }
        if (firstArrayStart < secondArrayStart)
            retVal = Math.Max(retVal, nums.Length - firstArrayStart);
        return retVal;
    }
}