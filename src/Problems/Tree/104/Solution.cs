using System;

namespace LeetCode.Problems.Tree._104;


//Definition for a binary tree node.
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public int MaxDepth(TreeNode root)
    {
        int retVal = 0;

        if (root is null)
            return retVal;
        retVal = 1;
        var left = TraverseLeft(root);
        var right = TraverseRight(root);

        return retVal + Math.Max(left, right);

    }
    int TraverseRight(TreeNode p)
    {
        return MaxDepth(p?.right);
    }
    int TraverseLeft(TreeNode p)
    {
        return MaxDepth(p?.left);
    }
}