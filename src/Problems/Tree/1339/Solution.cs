
namespace LeetCode.Problems.Tree._1339;

public class Solution
{
    private long _maxProduct = int.MinValue;
    const int Modulo = (int)(1E9 + 7);
    public int MaxProduct(TreeNode root)
    {
        long totalSum = GetTreeSum(root);

        GetMaxProductWithSum(root, totalSum);

        return (int)(_maxProduct % Modulo);
    }

    private long GetMaxProductWithSum(TreeNode root, long totalSum)
    {
        long rightSum = int.MinValue;
        long leftSum = int.MinValue;
        if (root.right is not null)
        {
            rightSum = GetMaxProductWithSum(root.right, totalSum);
            _maxProduct = Math.Max(_maxProduct, (totalSum - rightSum) * rightSum);
        }

        if (root.left is not null)
        {
            leftSum = GetMaxProductWithSum(root.left, totalSum);
            _maxProduct = Math.Max(_maxProduct, (totalSum - leftSum) * leftSum);
        }

        return root.val + (leftSum == int.MinValue ? 0 : leftSum) + (rightSum == int.MinValue ? 0 : rightSum);
    }

    private long GetTreeSum(TreeNode root)
    {
        long retVal = root.val;

        if (root.right is not null)
            retVal += GetTreeSum(root.right);

        if (root.left is not null)
            retVal += GetTreeSum(root.left);

        return retVal;
    }
}