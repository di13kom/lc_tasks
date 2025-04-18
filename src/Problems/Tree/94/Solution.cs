using System;

namespace LeetCode.Problems.Tree._94;

//  Definition for a binary tree node.
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
public class Solution
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        List<int> retVal = [];

        if(root is null)
            return retVal;
        TraverseLeft(root, retVal);
        retVal.Add(root.val);
        TraverseRight(root, retVal);

        return retVal;

    }
    void TraverseRight(TreeNode p, List<int> lst)
    {
        lst.AddRange(InorderTraversal(p?.right));
    }
    void TraverseLeft(TreeNode p, List<int> lst)
    {
        lst.AddRange(InorderTraversal(p?.left));
    }
}
