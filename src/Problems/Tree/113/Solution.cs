namespace LeetCode.Problems.Tree._113;

public class Solution
{
    int _targetSum;
    public IList<IList<int>> PathSum(TreeNode root, int targetSum)
    {
        _targetSum = targetSum;
        IList<IList<int>> retVal = [];
        if (root?.val is null)
            return retVal;

        var Childrenitems = TraverseNode(root);

        foreach (var item in Childrenitems)
        {
            item.Reverse();
            retVal.Add(item);
        }

        return retVal;
    }

    private List<List<int>> TraverseNode(TreeNode node, int parentVal = 0)
    {
        List<List<int>> retVal = [];
        var curNodeValue = parentVal + node.val;
        if (node.right is null && node.left is null)
        {
            if (curNodeValue == _targetSum)
                return [[node.val]];
        }

        if (node?.left is not null)
        {
            retVal.AddRange(TraverseNode(node.left, curNodeValue));
        }
        if (node?.right is not null)
        {
            retVal.AddRange(TraverseNode(node.right, curNodeValue));
        }
        foreach (var item in retVal)
        {
            item.Add(node.val);
        }

        return retVal;
    }
}
