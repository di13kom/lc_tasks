using System.Security.Cryptography.X509Certificates;

namespace LeetCode.Problems.Tree._102;

public class Solution
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        IList<IList<int>> retVal = [];
        if (root?.val is null)
            return retVal;

        var Childrenitems = TraverseNode(root, 0);

        var groups = Childrenitems.GroupBy(x => x.Item2, (k, v) => new { Level = k, Items = v });
        foreach (var item in groups.OrderBy(x => x.Level))
        {
            retVal.Add(item.Items.Select(x => x.Item1).ToList());
        }

        return retVal;
    }

    private List<(int, int)> TraverseNode(TreeNode node, int parentLevel)
    {
        List<(int, int)> retVal;
        List<(int, int)> leftLst = [];
        List<(int, int)> rightLst = [];
        if (node.right is null && node.left is null)
        {
            return [(node.val, ++parentLevel)];
        }

        if (node?.left is not null)
        {
            leftLst = TraverseNode(node.left, parentLevel + 1);
        }
        if (node?.right is not null)
        {
            rightLst = TraverseNode(node.right, parentLevel + 1);
        }

        retVal = Enumerable.Concat(leftLst, rightLst).ToList();
        retVal.Add((node.val, parentLevel + 1));

        return retVal;
    }
}
