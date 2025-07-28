namespace LeetCode.Problems._78;

public class Solution1
{
    public IList<IList<int>> Subsets(int[] nums)
    {
        int length = nums.Length;
        int subsets = 1 << length;
        List<IList<int>> retVal = [];
        for (int i = 0; i < subsets; i++)
        {
            List<int> lst = new List<int>();
            for (int j = 0; j < length; j++)
            {
                if ((i & (1 << j)) != 0)
                {
                    lst.Add(nums[j]);
                }
            }
            retVal.Add(lst);
        }

        return retVal;
    }
}