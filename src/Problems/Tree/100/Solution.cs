namespace LeetCode.Problems.Tree._100;

//Given the roots of two binary trees p and q, write a function to check if they are the same or not.
//Two binary trees are considered the same if they are structurally identical, and the nodes have the same value.

//  Definition for a binary tree node.
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
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p is null && q is null)
            return true;
        if (p?.val != q?.val)
            return false;
        if (!TraverseLeft(p, q))
            return false;
        if (!TraverseRight(p, q))
            return false;

        return true;
    }
    bool TraverseRight(TreeNode p, TreeNode q)
    {
        return IsSameTree(p?.right, q?.right);
    }
    bool TraverseLeft(TreeNode p, TreeNode q)
    {
        return IsSameTree(p?.left, q?.left);
    }
}
