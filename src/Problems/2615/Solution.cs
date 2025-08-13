namespace LeetCode.Problems._2615;

public class Solution
{
    private class ValueSum
    {
        public long Sum { get; set; }
        public uint Count { get; set; }
    }
    public long[] Distance(int[] nums)
    {
        DateTime dt = DateTime.Now;
        var length = nums.Length;

        long[] retVal = new long[length];
        Dictionary<int, ValueSum> increaseDict = [];
        Dictionary<int, ValueSum> decreaseDict = [];

        for (int i = 0; i < length; i++)
        {
            if (!increaseDict.TryAdd(nums[i], new ValueSum { Sum = i, Count = 1 }))
            {
                var item = increaseDict[nums[i]];
                retVal[i] = i * item.Count - item.Sum;
                item.Sum += i;
                item.Count++;
            }
        }

        // Console.WriteLine($"First part elapsed:{DateTime.Now - dt}");

        for (int i = length - 1; i >= 0; i--)
        {
            if (!decreaseDict.TryAdd(nums[i], new ValueSum { Sum = i, Count = 1 }))
            {
                var item = decreaseDict[nums[i]];
                retVal[i] += Math.Abs(i * item.Count - item.Sum);
                item.Sum += i;
                item.Count++;
            }
        }

        // Console.WriteLine($"Second part elapsed:{DateTime.Now - dt}");

        return retVal;
    }
}