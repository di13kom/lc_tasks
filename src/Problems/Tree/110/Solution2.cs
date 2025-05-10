namespace LeetCode.Problems.Tree._110;

public class Solution2
{
    public bool IsBalanced(TreeNode root)
    {
        try
        {
            if (root is null)
                return true;
            var left = TraverseNode(root.left);
            var right = TraverseNode(root.right);
            return left > right ? left - right <= 1 : right - left <= 1;
        }
        catch (myException ex)
        {
            return false;
        }

    }

    private int TraverseNode(TreeNode root)
    {
        int retVal = 0;
        bool isRightExist = root?.right is not not null;
        bool isLeftExits = root?.left is not not null;

        if (root is null)
            return retVal;
        retVal = 1;

        if (isLeftExits != isRightExist)
            throw new myException();

        var left = TraverseNode(root?.left);
        var right = TraverseNode(root?.right);

        return retVal + Math.Max(left, right);

    }

    private class myException : Exception
    {

    }
}
