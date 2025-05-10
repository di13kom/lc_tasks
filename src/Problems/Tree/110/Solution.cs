namespace LeetCode.Problems.Tree._110;

public class Solution
{
    public bool IsBalanced(TreeNode root)
    {
        if (root is null)
            return true;
        var left = TraverseNode(root.left);
        var right = TraverseNode(root.right);
        return Math.Abs(left - right) <= 1;
        //return left > right ? left - right <= 1 : right - left <= 1;

    }

    private int TraverseNode(TreeNode root)
    {

        if (root is null)
            return 0;

        var left = TraverseNode(root?.left);
        var right = TraverseNode(root?.right);

        return 1 + Math.Max(left, right);

    }
}
