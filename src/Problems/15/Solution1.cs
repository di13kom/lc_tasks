namespace LeetCode.Problems._15;

public class Solution1
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        IList<IList<int>> retVal = [];

        Array.Sort(nums);
        int targetIndex;
        int prevI = int.MinValue;
        int prevJ = int.MinValue;
        if (nums[0] == 0)
        {
            return (nums[0] == nums[1] && nums[1] == nums[2]) ? [[0, 0, 0]] : [];
        }
        else if (nums[0] > 0)
        {
            return [];
        }
        else
        {
            if (nums[nums.Length - 1] <= 0)
                return [];
            else
            {
                targetIndex = nums.Length - 1;
            }
        }

        for (int i = 0; i <= targetIndex - 2; i++)
        {
            if (nums[i] == prevI || nums[i]>0)
                continue;
            for (int j = i + 1; j <= targetIndex - 1; j++)
            {
                if (nums[j] == prevJ)
                    continue;

                var vl = (nums[i] + nums[j]) * -1;
                var idx = Array.BinarySearch(nums, vl);
                if (idx > 0 && ((idx > j) || (nums[idx] == nums[j + 1])))
                {
                    retVal.Add([nums[i], nums[j], vl]);
                }
                prevJ = nums[j];
            }
            prevI = nums[i];
        }
        return retVal;
    }
}