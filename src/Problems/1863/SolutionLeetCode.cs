using System;

namespace LeetCode.Problems._1863;

public class SolutionLeetCode
{
    public int SubsetXORSum(int[] nums)
    {
        return DFS(nums, 0, 0);
    }

    private int DFS(int[] nums, int index, int currentXOR)
    {
        if (index == nums.Length)
        {
            return currentXOR;
        }

        int withCurrent = DFS(nums, index + 1, currentXOR ^ nums[index]);

        int withoutCurrent = DFS(nums, index + 1, currentXOR);

        return withCurrent + withoutCurrent;
    }

    public int SubsetXORSum2(int[] nums)
    {
        int x = 0;
        foreach (int num in nums)
        {
            x |= num;
        }
        Console.Write(x);
        return x * (int)Math.Pow(2, nums.Length - 1);
    }

    public int SubsetXORSum1(int[] nums)
    {
        int totalXorSum = 0;
        int numberOfSubsets = 1 << nums.Length;  // This is 2^n

        for (int subsetMask = 0; subsetMask < numberOfSubsets; subsetMask++)
        {
            int currentXor = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if ((subsetMask & (1 << i)) != 0)
                {  // Check if the ith element is included in the current subset
                    currentXor ^= nums[i];
                }
            }
            totalXorSum += currentXor;
        }

        return totalXorSum;
    }
}
