namespace LeetCode.Problems._2044;

public class Solution
{
    public int CountMaxOrSubsets(int[] nums)
    {
        var length = nums.Length;

        var variants = 1 << length;

        int retVal = 0;
        int maxValue = 0;

        for (int i = 0; i < variants; i++)
        {
            var curValue = 0;
            IList<int> debugList = [];
            for (int j = 0; j < length; j++)
            {
                if ((i & (1 << j)) != 0)
                {
                    curValue |= nums[j];
                    debugList.Add(nums[j]);
                }
            }
            PrintEnumerable(debugList);
            if (curValue >= maxValue)
            {
                retVal = curValue > maxValue ? 1 : retVal + 1;
                maxValue = curValue;
            }
        }
        return retVal;
    }
    private void PrintEnumerable(IEnumerable<int> ints)
    {
        Console.Write("[");
        foreach (var item in ints)
        {
            Console.WriteLine($"|{item}|");
        }
        Console.Write("]");
    }
}