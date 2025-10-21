

namespace LeetCode.Problems.Tree._2415;

public class Solution
{
    readonly Dictionary<int, List<TreeNode>> treeNodes = [];
    public TreeNode ReverseOddLevels(TreeNode root)
    {
        TraverseRoot(root, 1);

        foreach (KeyValuePair<int, List<TreeNode>> item in treeNodes)
        {
            int length = item.Value.Count;

            for (int i = 0; i < length / 2; i++)
            {
                int tmp = item.Value[i].val;
                item.Value[i].val = item.Value[length - 1 - i].val;
                item.Value[length - 1 - i].val = tmp;
            }

        }
        return root;
    }

    private void TraverseRoot(TreeNode root, int level)
    {
        if (root.left is not null && root.right is not null)
        {
            if (level % 2 != 0)
            {
                if (!treeNodes.TryAdd(level, [root.left, root.right]))
                {
                    treeNodes[level].Add(root.left);
                    treeNodes[level].Add(root.right);
                }
            }
            TraverseRoot(root.left, level + 1);
            TraverseRoot(root.right, level + 1);
        }
    }
}