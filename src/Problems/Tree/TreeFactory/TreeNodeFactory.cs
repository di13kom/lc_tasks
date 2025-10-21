using LeetCode.Problems.Tree;

namespace LeetCode.Problems.Tree;

public class TreeNodeFactory
{
    public static TreeNode CreateBinaryTreeNodeFromArray(int?[] array)
    {
        int length = array.Length;

        if (length < 1 || array.ElementAt(0) is null)
            return null;
        var root = new TreeNode(array[0].Value);
        Queue<TreeNode> nodesQueue = new Queue<TreeNode>([root]);

        int k = 1;

        while (k < length)
        {
            var levelCount = nodesQueue.Count;
            for (int i = 0; i < levelCount; i++)
            {
                if (nodesQueue.TryDequeue(out var parentNode) && parentNode is not null)
                {
                    if (k >= length)
                        break;
                    var leftValue = array[k++];
                    TreeNode leftNode = leftValue.HasValue ? new TreeNode(leftValue.Value) : null;
                    parentNode.left = leftNode;
                    nodesQueue.Enqueue(leftNode);

                    if (k >= length)
                        break;
                    var rightValue = array[k++];
                    TreeNode rightNode = rightValue.HasValue ? new TreeNode(rightValue.Value) : null;
                    parentNode.right = rightNode;
                    nodesQueue.Enqueue(rightNode);
                }
            }
        }

        return root;
    }
    public static IEnumerable<int?> CreateEnumerableFromBinaryTreeNode(TreeNode root)
    {
        Queue<TreeNode> nodesQueue = new Queue<TreeNode>([root]);
        List<int?> retVal = [];
        var levelCount = nodesQueue.Count;
        while (levelCount > 0)
        {
            bool isNewLevelAdded = false;
            for (int i = 0; i < levelCount; i++)
            {
                if (nodesQueue.TryDequeue(out TreeNode node))
                {
                    retVal.Add(node?.val);
                    if (node is not null && (node.left is not null || node.right is not null || isNewLevelAdded))
                    {
                        nodesQueue.Enqueue(node.left);
                        nodesQueue.Enqueue(node.right);
                        isNewLevelAdded = true;
                    }
                }
            }

            levelCount = nodesQueue.Count;
        }

        return retVal;
    }
}