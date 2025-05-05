using System;

namespace LeetCode.Problems.PrefixSum._303;

public class NumArray
{
    readonly int[] _nums;
    public NumArray(int[] nums)
    {
        _nums = nums;
    }

    public int SumRange(int left, int right)
    {
        if (left == right)
            return _nums[left];

        return _nums[left] + SumRange(++left, right);
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */