
namespace LeetCode.Problems.Tree._95;

public class Solution
{
    public IList<TreeNode> GenerateTrees(int n)
    {
        List<TreeNode> retVal = [];
        for (int i = 1; i <= n; i++)
        {
            retVal.AddRange(GenerateTrees(i, 1, n));
        }
        return retVal;
    }

    private IEnumerable<TreeNode> GenerateTrees(int rootVal, int startNumber, int endNumber)
    {
        List<TreeNode> leftNodes = [];
        List<TreeNode> rightNodes = [];
        List<TreeNode> retVal = [];
        for (int i = startNumber; i < rootVal; i++)
        {
            leftNodes.AddRange(GenerateTrees(i, startNumber, rootVal - 1));
        }
        for (int i = rootVal + 1; i <= endNumber; i++)
        {
            rightNodes.AddRange(GenerateTrees(i, rootVal + 1, endNumber));
        }

        foreach (var leftNode in leftNodes.Count == 0 ? [null] : leftNodes)
        {
            foreach (var rightNode in rightNodes.Count == 0 ? [null]:rightNodes)
            {
                TreeNode root = new(rootVal, leftNode, rightNode);
                retVal.Add(root);
            }
        }
        return retVal;
    }
}