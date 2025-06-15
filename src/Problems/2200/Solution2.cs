namespace LeetCode.Problems._2200;

public class Solution2
{
    public IList<int> FindKDistantIndices(int[] nums, int key, int k)
    {
        var length = nums.Length;
        IList<int> targetIndexes = [];
        HashSet<int> retVal = [];

        for (int i = 0; i < length; i++)
        {
            if (nums[i] == key)
            {
                retVal.Add(i);
                for (int j = 1; j <= k; j++)
                {
                    //left
                    if (i - j >= 0)
                        retVal.Add(i - j);

                    //right
                    if (i + j < length)
                        retVal.Add(i + j);
                }
            }
        }
        return retVal.Order().ToList();
    }
}