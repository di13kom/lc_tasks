
using System.Formats.Asn1;

namespace LeetCode.Problems._3024;

public class Solution
{
    public string TriangleType(int[] nums)
    {
        if (!IsValidTriangle(nums))
            return "none";
        else if (IsEquilateral(nums))
            return "equilateral";
        else if (IsIsoscelesTriangle(nums))
            return "isosceles";
        return "scalene";
    }

    private static bool IsEquilateral(int[] nums)
    {
        return nums[0] == nums[1] && nums[0] == nums[2];
    }

    private static bool IsIsoscelesTriangle(int[] nums)
    {
        return nums[0] == nums[1] || nums[0] == nums[2] || nums[1] == nums[2];
    }

    private static bool IsValidTriangle(int[] nums)
    {
        return nums[0] + nums[1] > nums[2] && nums[0] + nums[2] > nums[1] && nums[2] + nums[1] > nums[0];
    }
}