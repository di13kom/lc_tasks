namespace LeetCode.Problems._283;

public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        var length = nums.Length;
        int j;

        for (int i = 0; i < length; i++)
        {
            if (nums[i] == 0)
            {
                j = i + 1;
                while (j < length)
                {
                    if (nums[j] != 0)
                    {
                        var tmp = nums[j];
                        nums[j] = nums[i];
                        nums[i] = tmp;
                        break;
                    }
                    j++;
                }
            }
        }
    }
}