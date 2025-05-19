namespace LeetCode.Problems.PrefixSum._3355;

public class Solution
{
    public bool IsZeroArray(int[] nums, int[][] queries)
    {
        var length = nums.Length;

        int[] diffArray = new int[length + 1];

        foreach (var item in queries)
        {
            diffArray[item[0]] += 1;
            diffArray[item[1] + 1] -= 1;
        }

        Console.WriteLine("Diff");
        Array.ForEach(diffArray, x => Console.Write($"|{x}|"));

        for (int i = 1; i < length + 1; i++)
        {
            diffArray[i] = diffArray[i] + diffArray[i - 1];
        }
        Console.WriteLine("\nPrefix");
        Array.ForEach(diffArray, x => Console.Write($"|{x}|"));

        Console.WriteLine("\n==Final==");
        for (int i = 0; i < length; i++)
        {
            var vl = diffArray[i] > nums[i] ? 0 : (uint)(nums[i] - diffArray[i]);
            Console.Write($"|{vl}|");
            if (vl > 0)
                return false;
        }
        //Console.WriteLine("\nFact");
        //Array.ForEach(targetArray, x => Console.Write($"|{x}|"));

        //return targetArray.All(x => x == 0);
        return true;
    }

}