using System;

namespace LeetCode.Problems.Tree._94;

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
