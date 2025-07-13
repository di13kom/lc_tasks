namespace LeetCode.Problems._15;

class ListEqualityComparer : IEqualityComparer<IList<int>>
{
    public bool Equals(IList<int>? lst1, IList<int>? lst2)
    {
        if (ReferenceEquals(lst1, lst2))
            return true;

        if (lst2 is null || lst1 is null)
            return false;

        return lst1[0] == lst2[0]
            && lst1[1] == lst2[1]
            && lst1[2] == lst2[2]
            ;
    }

    public int GetHashCode(IList<int> lst) => lst[0] ^ lst[1] ^ lst[2];
}
public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        HashSet<IList<int>> retVal = new HashSet<IList<int>>(new ListEqualityComparer());

        Array.Sort(nums);
        int targetIndex;
        if (nums[0] == 0)
        {
            targetIndex = Array.LastIndexOf(nums, 0);
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
                targetIndex = Array.BinarySearch(nums, (nums[0] * -1));
                targetIndex = targetIndex > 0 ? targetIndex : (~targetIndex > nums.Length - 1 ? nums.Length - 1 : ~targetIndex);
            }
        }

        for (int i = 0; i <= targetIndex - 2; i++)
        {
            for (int j = i + 1; j <= targetIndex - 1; j++)
            {
                for (int k = j + 1; k <= targetIndex; k++)
                {

                    int targetsum = nums[i] + nums[j] + nums[k];
                    if (targetsum == 0)
                    {
                        retVal.Add([nums[i], nums[j], nums[k]]);
                    }
                }
            }

        }
        return retVal.ToList();
    }
}