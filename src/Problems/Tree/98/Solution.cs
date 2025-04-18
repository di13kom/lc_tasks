using System;

namespace LeetCode.Problems.Tree._98;


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
    public bool IsValidBST(TreeNode root)
    {
        if (root?.left is null && root?.right is null)
            return true;
        if (root?.val <= root?.left?.val || root?.val >= root?.right?.val)
            return false;
        return IsValidBST(root?.right) && IsValidBST(root?.left);
    }
}
