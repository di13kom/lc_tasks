namespace LeetCode.Problems._2200;

public class Solution3
{
    public IList<int> FindKDistantIndices(int[] nums, int key, int k)
    {
        var length = nums.Length;
        int LastAddedIndex = -1;
        IList<int> retVal = [];

        for (int i = 0; i < length; i++)
        {
            if (nums[i] == key)
            {
                for (int j = i - k > LastAddedIndex ? i - k : LastAddedIndex + 1; j < i; j++)
                {
                    //left
                    retVal.Add(j);
                    LastAddedIndex = j;
                }

                if (LastAddedIndex < i)
                {
                    retVal.Add(i);
                    LastAddedIndex = i;
                }


                for (int j = i + 1 > LastAddedIndex ? i + 1 : LastAddedIndex + 1; j <= i + k && j < length; j++)
                {
                    //right
                    retVal.Add(j);
                    LastAddedIndex = j;

                }
            }
        }
        return retVal;
    }
}