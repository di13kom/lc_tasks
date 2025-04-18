namespace LeetCode.Problems.Tree._144;


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
    List<int> Ints = [];
    public IList<int> PreorderTraversal(TreeNode root)
    {
        if (root is not null)
            TraverseTree(root);
        return Ints;
    }
    private void TraverseTree(TreeNode root)
    {
        Ints.Add(root.val);
        if (root.left is not null)
            TraverseTree(root.left);
        if (root.right is not null)
            TraverseTree(root.right);
    }
}
