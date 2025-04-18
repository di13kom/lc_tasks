using System;

namespace LeetCode.Problems.Tree._257;

public class Solution
{
    public IList<string> BinaryTreePaths(TreeNode root)
    {
        var result = TraverseNode(root);

        var res = result.Select(x => string.Join("", x)).ToList();
        return res;
    }

    public List<List<string>> TraverseNode(TreeNode node)
    {
        if (node.right is null && node.left is null)
        {
            return [[node.val.ToString()]];
        }

        List<List<string>> leftNode = [];
        List<List<string>> rightNode = [];
        if (node?.left is not null)
        {
            leftNode = TraverseNode(node.left);
            for (int i = 0; i < leftNode.Count; i++)
            {
                leftNode[i] = leftNode[i].Prepend("->").Prepend(node.val.ToString()).ToList();
            }
        }
        if (node?.right is not null)
        {
            rightNode = TraverseNode(node.right);
            for (int i = 0; i < rightNode.Count; i++)
            {
                rightNode[i] = rightNode[i].Prepend("->").Prepend(node.val.ToString()).ToList();
            }
        }

        leftNode.AddRange(rightNode);

        return leftNode;

    }
}
