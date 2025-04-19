using System;

namespace LeetCode.Problems.Tree._108;


public class Solution
{
    public TreeNode SortedArrayToBST(int[] nums, TreeNode parent = null)
    {
        if (nums == null || nums.Length == 0)
            return null;

        var pivot = nums.Length / 2;
        var s = pivot + 1;
        var left = nums[0..pivot];
        var right = nums[s..];

        TreeNode curValue = new(nums[pivot]);
        if (parent?.val > curValue.val)
            parent.left = curValue;
        else if(parent?.val < curValue.val)
            parent.right = curValue;
        if (left.Length > 0)
            SortedArrayToBST(left, curValue);
        if (right.Length > 0)
            SortedArrayToBST(right, curValue);

        return curValue;
    }

    /*
    void TraverseArray(int[] nums, TreeNode parent)
    {
        var pivot = nums.Length / 2;
        var s = pivot + 1;

        var left = nums[0..pivot];
        var right = nums[s..];

        TreeNode curValue = new(nums[pivot]);
        TraverseArray(left, curValue);
        TraverseArray(right, curValue);

        return curValue;
    }
    */
}
