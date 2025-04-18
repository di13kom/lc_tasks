namespace LeetCode.Problems.Tree._144;


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
