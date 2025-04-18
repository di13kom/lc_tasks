namespace LeetCode.Problems.Tree._98;

public class Solution2
{
    List<int> Ints = [];
    public bool IsValidBST(TreeNode root)
    {
        if (root is null)
            return false;
        TraverseTree(root);
        return IsSorted(Ints);
    }

    private void TraverseTree(TreeNode root)
    {
        if (root.left is not null)
            TraverseTree(root.left);
        Ints.Add(root.val);
        if (root.right is not null)
            TraverseTree(root.right);
    }

    public bool IsSorted(IList<int> ints)
    {
        var length = ints.Count();
        if (length == 0)
            return false;
        if (length == 1)
            return true;
        long prevValue = long.MinValue;
        for (int i = 0; i < length; i++)
        {
            if (ints.ElementAt(i) <= prevValue)
                return false;
            prevValue = ints.ElementAt(i);
        }
        return true;
    }

}
