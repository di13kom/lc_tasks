namespace LeetCode.Problems._2962;

public class Solution
{
    public long CountSubarrays(int[] nums, int k)
    {
        int Length = nums.Length;
        int leftIndex = Length / 2;
        int rightIndex = leftIndex;
        SortedDictionary<int, int> dict = [];
        long retVal = 0;
        int iter = 0;
        List<int> maxIndex = [];
        for (int i = 0; i < Length; i++)
        {
            int item = nums[i];
            if (!dict.TryAdd(item, 1))
            {
                dict[item]++;
            }
        }
        var maxValue = dict.Last();

        if (maxValue.Value < k)
            return 0;

        if (nums[leftIndex] == maxValue.Key)
            maxIndex.Add(leftIndex);
        while (leftIndex > 0 && rightIndex < Length)
        {

            if (++iter % 2 == 0)
            {
                if (nums[--leftIndex] == maxValue.Key)
                    maxIndex.Add(leftIndex);
                retVal += IterateString(leftIndex, rightIndex, maxIndex);
            }
            else
            {
                if (nums[++rightIndex] == maxValue.Key)
                    maxIndex.Add(rightIndex);
                retVal += IterateString(rightIndex, leftIndex, maxIndex);
            }
        }


        return retVal;
    }

    private int IterateString(int startIndex, int stopIndex, IEnumerable<int> targetIndex)
    {
        int retVal = 0;

        if (startIndex < stopIndex)
        {
            for (int i = startIndex; i < stopIndex; i++)
            {
                //retVal += targetIndex.All(x => x >= startIndex && x <= stopIndex) ? 1 : 0;
                retVal += targetIndex.First() >= i && targetIndex.Last() <= stopIndex ? 1 : 0;
            }
        }
        else
        {
            for (int i = stopIndex; i > startIndex; i--)
            {
                //retVal += targetIndex.All(x => x >= startIndex && x <= stopIndex) ? 1 : 0;
                retVal += targetIndex.First() >= i && targetIndex.Last() <= stopIndex ? 1 : 0;
            }

        }

        return retVal;
    }
}