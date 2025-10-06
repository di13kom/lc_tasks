namespace LeetCode.Problems._1018;

public class Solution
{
    public IList<bool> PrefixesDivBy5(int[] nums)
    {
        ulong curSumValue = 0;
        int length = nums.Length;
        IList<bool> retVal = [];

        for (int i = 0; i < length; i++)
        {
            curSumValue <<= 1;
            curSumValue += (uint)nums[i];
            if (curSumValue % 5 == 0)
            {
                retVal.Add(true);
            }
            else
            {
                retVal.Add(false);
            }
            curSumValue %= 5;
        }
        return retVal;
    }
}