namespace LeetCode.Problems._78;

public class Solution
{
    public IList<IList<int>> Subsets(int[] nums)
    {
        var length = nums.Length;
        IList<IList<int>> retVal = [[]];

        for (int i = 0; i < length; i++)
        {
            IList<IList<int>> newList = [];
            foreach (var item in retVal)
            {
                newList.Add(item.Append(nums[i]).ToList());
            }
            retVal = retVal.Concat(newList).ToList();
        }

        return retVal;
    }

}