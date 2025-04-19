namespace LeetCode.Problems.Tree._145;



public class Solution
{
    List<int> Ints = [];
    public IList<int> PostorderTraversal(TreeNode root)
    {
        if (root is not null)
            TraverseTree(root);
        return Ints;
    }
    private void TraverseTree(TreeNode root)
    {
        if (root.left is not null)
            TraverseTree(root.left);
        if (root.right is not null)
            TraverseTree(root.right);
        Ints.Add(root.val);
    }
}
