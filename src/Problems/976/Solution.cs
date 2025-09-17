namespace LeetCode.Problems._976;

public class Solution
{
    public int LargestPerimeter(int[] nums)
    {
        int length = nums.Length;
        Array.Sort(nums);
        int retVal = 0;

        for (int i = length - 1; i >= 2; i--)
        {
            for (int j = i - 1; j >= 1; j--)
            {
                if (nums[i] > nums[j] + nums[j - 1])
                {
                    continue;
                }
                for (int k = j - 1; k >= 0; k--)
                {
                    if (IsValidTraingle(nums[i], nums[j], nums[k]))
                    {
                        return nums[i] + nums[j] + nums[k];
                    }
                }
            }
        }

        return retVal;
    }

    //Valid Triangle means if you added length of any 2 side it will be greater than 3rd side length
    private bool IsValidTraingle(int x, int y, int z)
    {
        return x + y > z && z + y > x && x + z > y;
    }
}