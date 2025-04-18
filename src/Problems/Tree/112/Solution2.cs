namespace LeetCode.Problems._112;

public class Solution2
{
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        if (root?.left is null && root?.right is null)
        {
            return root?.val == targetSum;
        }

        return HasPathSum(root.left, targetSum - root.val) || HasPathSum(root.right, targetSum - root.val);
    }
}