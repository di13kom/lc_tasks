using System;

namespace LeetCode.Problems._112;


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
    HashSet<int> PathSums = [];
    public bool HasPathSum(TreeNode root, int targetSum)
    {

        if (root is null)
            return false;

        TraverseNode(root, 0);

        return PathSums.Contains(targetSum);
    }
    private void TraverseNode(TreeNode node, int parentVal)
    {
        if (node.right is null && node.left is null)
        {
            PathSums.Add(parentVal + node.val);
            return;
        }
        TraverseLeft(node, parentVal + node.val);
        TraverseRight(node, parentVal + node.val);
    }

    private void TraverseLeft(TreeNode root, int parentVal)
    {
        if (root?.left is not null)
            TraverseNode(root?.left, parentVal);
    }

    private void TraverseRight(TreeNode root, int parentVal)
    {
        if (root?.right is not null)
            TraverseNode(root?.right, parentVal);
    }
}
