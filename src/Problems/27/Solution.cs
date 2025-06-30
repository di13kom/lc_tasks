using System.Security.Cryptography.X509Certificates;

namespace LeetCode.Problems._27;

public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        if (nums.Length == 0)
            return 0;
        int retVal = 0;
        int substIndex = nums.Length - 1;
        for (int i = 0; i < substIndex; i++)
        {
            while (nums[substIndex] == val && substIndex > i)
            {
                substIndex--;
            }
            if (substIndex == i)
                break;
            if (nums[i] == val)
            {
                nums[i] = nums[substIndex];
                nums[substIndex] = val;
            }
        }

        retVal = Array.IndexOf(nums, val);

        return retVal >= 0 ? retVal : nums.Length;
    }
}