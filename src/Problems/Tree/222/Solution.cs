using System;

namespace LeetCode.Problems.Tree._222;


public class Solution
{
    public int CountNodes(TreeNode root)
    {
        if (root is null)
            return 0;

        return 1 + CountNodes(root?.left) + CountNodes(root?.right);
    }
}
