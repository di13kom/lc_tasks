namespace LeetCode.Problems.Tree._1161;

public class Solution
{
    int maxLevel = 0;
    public int MaxLevelSum(TreeNode root)
    {
        int maxSum = int.MinValue;
        Queue<TreeNode> queue = new([root]);

        TraverseNode(queue, 1, maxSum);

        return maxLevel;
    }

    private void TraverseNode(Queue<TreeNode> nodes, int level, int maxSum)
    {
        Queue<TreeNode> childrenQueue = [];
        int sum = 0;
        while (nodes.TryDequeue(out var node))
        {
            sum += node.val;
            if (node.left != null)
                childrenQueue.Enqueue(node.left);
            if (node.right != null)
                childrenQueue.Enqueue(node.right);
        }
        if (sum > maxSum)
        {
            maxLevel = level;
            maxSum = sum;
        }

        if (childrenQueue.Count > 0)
        {
            TraverseNode(childrenQueue, level + 1, maxSum);
        }
    }
}