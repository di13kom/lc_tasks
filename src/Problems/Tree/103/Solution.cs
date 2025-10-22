namespace LeetCode.Problems.Tree._103;

public class Solution
{
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
    {
        IList<IList<int>> retVal = [];

        if (root == null)
            return retVal;

        Queue<TreeNode> nodesValues = new Queue<TreeNode>([root]);
        int level = 1;

        while (nodesValues.Count > 0)
        {
            int length = nodesValues.Count;
            retVal.Add([]);

            for (int i = 0; i < length; i++)
            {
                if (nodesValues.TryDequeue(out var node))
                {
                    if (node.left is not null)
                    {
                        nodesValues.Enqueue(node.left);
                    }
                    if (node.right is not null)
                    {
                        nodesValues.Enqueue(node.right);
                    }
                }
                if (level % 2 != 0)
                {
                    retVal.Last().Add(node.val);
                }
                else
                {
                    retVal.Last().Insert(0, node.val);
                }
            }
            level++;
        }
        return retVal;
    }

}