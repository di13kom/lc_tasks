namespace LeetCode.Problems._611;

public class Solution
{
    public int TriangleNumber(int[] nums)
    {
        int retVal = 0;
        int length = nums.Length;
        if (length < 3)
            return 0;
        Array.Sort(nums);

        for (int i = length - 1; i >= 2; i--)
        {
            for (int j = i - 1; j >= 1; j--)
            {
                var idx = Array.BinarySearch(nums, 0, j, nums[i] - nums[j]);
                if (idx < 0)
                {
                    idx = ~idx;
                    while (idx < j - 1 && nums[idx] + nums[j] <= nums[i])
                    {
                        idx++;
                    }
                }
                else if (idx < j - 1 && nums[idx] + nums[j] <= nums[i])
                {
                    while (idx < j - 1 && nums[idx] + nums[j] <= nums[i])
                    {
                        idx++;
                    }
                }

                if (IsValidTraingle(nums[i], nums[j], nums[idx]))
                    retVal += j - idx;
            }
        }
        return retVal;
    }
    private bool IsValidTraingle(double x, double y, double z)
    {
        return x + y > z && z + y > x;
    }
}