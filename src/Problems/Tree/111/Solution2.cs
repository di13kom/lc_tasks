namespace LeetCode.Problems.Tree._111;

public class Solution2
{
    public int MinDepth(TreeNode root)
    {
        if (root is null)
            return 0;
        if (root?.right is null && root?.left is null)
        {
            return 1;
        }

        return 1 + Math.Min(root?.left != null ? MinDepth(root?.left) : short.MaxValue, root.right != null ? MinDepth(root?.right) : short.MaxValue);
    }
}
