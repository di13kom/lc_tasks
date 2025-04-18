using System;

namespace LeetCode.Problems.Tree._111;


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
    readonly List<int> depthes = [];
    public int MinDepth(TreeNode root, int depth = 0)
    {
        int retVal = 0;
        if (root is null)
        {
            depthes.Add(depth);
            return 0;
        }
        int rDepth = TraverseRight(root, depth);
        int lDepth = TraverseLeft(root, depth);

        return retVal + Math.Min(rDepth, lDepth);
    }
    private int TraverseLeft(TreeNode root, int depth)
    {
        return MinDepth(root?.left, depth);
    }

    private int TraverseRight(TreeNode root, int depth)
    {
        return MinDepth(root?.right, depth);
    }
}
