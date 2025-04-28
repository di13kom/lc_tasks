using System;
using System.Diagnostics;

namespace LeetCode.Problems._1863;

public class Solution
{
    public int SubsetXORSum(int[] nums)
    {
        int sum = 0;
        List<List<int>> elemList = [[0]];
        foreach (var item in nums)
        {
            List<List<int>> newElemList = [];
            for (int i = 0; i < elemList.Count; i++)
            {
                var nL = elemList[i].Prepend(item).ToList();
                sum += nL.Aggregate(0, (x, y) => x ^ y);
                newElemList.Add(nL);
            }
            elemList.AddRange(newElemList);
        }
        PrintListList(elemList);
        return sum;
    }

    private int subsetOfSubset(int[] nums)
    {
        if (nums.Count() == 1)
            return nums[0];

        int retVal = nums.Aggregate(0, (x, y) => x ^ y);

        for (int i = 1; i < nums.Length; i++)
        {
            var arr = nums.Except([nums[i]]);
            PrintArray(arr, Array.Empty<int>());
            retVal += arr.Aggregate(0, (x, y) => x ^ y);
        }

        return retVal += SubsetXORSum(nums[1..]);

    }

    private int subsetOfSubset2(int[] nums)
    {
        int retVal = nums.Aggregate(0, (x, y) => x ^ y);
        for (int j = 0; j < nums.Length - 1; j++)
        {
            for (int i = j + 1; i < nums.Length; i++)
            {
                var arr = nums.Except(nums[j..i]);
                PrintArray(nums[j..i], arr);
                var includeSum = arr.Aggregate(0, (x, y) => x ^ y);
                var excludeSum = nums[j..i].Aggregate(0, (x, y) => x ^ y);

                retVal += includeSum + excludeSum;
            }
        }
        return retVal;
    }

    private void PrintArray(IEnumerable<int> excludedArray, IEnumerable<int> IncludeArray)
    {
        foreach (var item in IncludeArray)
        {
            Console.Write(item);
        }
        Console.Write("|");
        foreach (var item in excludedArray)
        {
            Console.Write(item);
        }
        Console.WriteLine("");

    }

    private void PrintListList(List<List<int>> IncludeArray)
    {
        foreach (var item in IncludeArray)
        {
            foreach (var subItem in item)
            {
                Console.Write(subItem);
                Console.Write("|");
            }
            Console.WriteLine();
        }

    }

}
