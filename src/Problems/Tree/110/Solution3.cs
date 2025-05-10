using System;

namespace LeetCode.Problems.Tree._110;

public class Solution3
{
    // Function to calculate the height of a tree
    int height(TreeNode node)
    {

        // Base case: Height of empty tree is zero
        if (node == null)
            return 0;

        // Height = 1 + max of left height and right heights
        return 1 + Math.Max(height(node.left), height(node.right));
    }

    // Function to check if the binary tree with given root is height-balanced
    public bool IsBalanced(TreeNode root)
    {

        // If tree is empty then return true
        if (root == null)
            return true;

        // Get the height of left and right subtrees
        int lHeight = height(root.left);
        int rHeight = height(root.right);

        // If absolute height difference is greater than 1
        // Then return false
        if (Math.Abs(lHeight - rHeight) > 1)
            return false;

        // Recursively check the left and right subtrees
        return IsBalanced(root.left) && IsBalanced(root.right);
    }
}
