namespace LeetCode.Problems.Tree._222;

public class Solution2
{
    public int CountNodes(TreeNode root)
    {
        int leftCount = 0;
        int rightCont = 0;

        if (root is null)
            return 0;

        if (root.right is not null)
            rightCont = CountNodes(root.right);

        if (root.left is not null)
            leftCount = CountNodes(root.left);

        return 1 + leftCount + rightCont;
    }
}
