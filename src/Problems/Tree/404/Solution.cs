namespace LeetCode.Problems.Tree._404;

public class Solution
{
    public int SumOfLeftLeaves(TreeNode root)
    {
        if (root is null || (root.left is null && root.right is null))
            return 0;
        return TraverseTree(root.left, true) + TraverseTree(root.right, false);
    }

    private int TraverseTree(TreeNode root, bool isLeft = false)
    {
        int leftCount = 0;
        int rightCont = 0;
        int retVal = 0;

        if (root is null)
            return 0;

        if (root.right is null && root.left is null && isLeft == true)
            retVal = root.val;

        if (root.right is not null)
            rightCont = TraverseTree(root.right, false);

        if (root.left is not null)
            leftCount = TraverseTree(root.left, true);

        return retVal + leftCount + rightCont;
    }
}
