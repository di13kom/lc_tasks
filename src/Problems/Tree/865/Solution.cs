namespace LeetCode.Problems.Tree._865;

public class Solution
{

    int[] _maxLevelWithCount = [0, 0];
    public TreeNode SubtreeWithAllDeepest(TreeNode root)
    {
        TraverseNode(root, 0);
        Console.WriteLine($"Max level:{_maxLevelWithCount[0]} with quantity:{_maxLevelWithCount[1]}");

        return FindDeepestBranch(root, 0);
    }

    private TreeNode FindDeepestBranch(TreeNode root, int level)
    {
        if (root.left is null && root.right is null)
        {
            if (level == _maxLevelWithCount[0])
            {
                Console.WriteLine($"Return root.val {root.val} at {level} level");
                return root;
            }
            else
            {
                return null;
            }
        }

        TreeNode leftBranch = null;
        TreeNode rightBranch = null;
        if (root.left is not null)
        {
            leftBranch = FindDeepestBranch(root.left, level + 1);
        }
        if (root.right is not null)
        {
            rightBranch = FindDeepestBranch(root.right, level + 1);
        }

        if (leftBranch is not null && rightBranch is not null)
        {
            Console.WriteLine($"Connection at {level} level. root:{root.val}, left:{root?.left?.val}, right:{root?.right?.val}");
            return root;//Crusial point - return root.
        }

        else if (leftBranch is not null || rightBranch is not null)
        {
            Console.WriteLine($"Pass root at {level} level. root:{root.val}, left:{root?.left?.val}, right:{root?.right?.val}");
            return leftBranch is null ? rightBranch : leftBranch;
        }

        return null;
    }

    private void TraverseNode(TreeNode root, int level)
    {
        if (level > _maxLevelWithCount[0])
        {
            _maxLevelWithCount[0] = level;
            _maxLevelWithCount[1] = 1;
        }
        else if (level == _maxLevelWithCount[0])
        {
            _maxLevelWithCount[1]++;
        }

        if (root.left is not null)
        {
            TraverseNode(root.left, level + 1);
        }
        if (root.right is not null)
        {
            TraverseNode(root.right, level + 1);
        }
    }
}