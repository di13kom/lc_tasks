namespace LeetCode.Problems._896;

public class Solution
{
    public bool IsMonotonic(int[] nums)
    {
        if (nums.Length <= 2)
            return true;

        int adjacentMinMaxValue = nums[1];
        int preAdjacentMinMaxValue = nums[0];

        for (int i = 2; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                if (nums[i] > adjacentMinMaxValue
                    && adjacentMinMaxValue >= preAdjacentMinMaxValue
                    && nums[i] >= nums[i - 1])
                {
                    preAdjacentMinMaxValue = Math.Min(adjacentMinMaxValue, preAdjacentMinMaxValue);
                    adjacentMinMaxValue = nums[i - 1];
                }
                else if (nums[i] < adjacentMinMaxValue
                        && adjacentMinMaxValue <= preAdjacentMinMaxValue
                         && nums[i] <= nums[i - 1])
                {

                    preAdjacentMinMaxValue = Math.Max(adjacentMinMaxValue, preAdjacentMinMaxValue);
                    adjacentMinMaxValue = nums[i - 1];
                }
                else
                    return false;
            }

        }

        return true;
    }
}