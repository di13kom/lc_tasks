namespace LeetCode.Problems.Tree._101;

public class Solution
{
    public bool IsSymmetric(TreeNode root)
    {
        bool retVal;

        var lstLeft = TraverseNode(root?.left);
        var lstRiht = TraverseNode(root?.right);


        return CompareLists(lstLeft, lstRiht);

    }
    List<int> TraverseNode(TreeNode node)
    {
        List<int> lst = [];
        if (node is null)
        {
            return lst;
        }
        if (node.left is null && node.right is not null)
        {
            lst.Add(-101);
            lst.Add(node.val);
            lst.AddRange(TraverseRight(node));
            return lst;
        }
        if (node.right is null && node.left is not null)
        {
            lst.AddRange(TraverseLeft(node));
            lst.Add(node.val);
            lst.Add(-101);
            return lst;
        }

        lst.AddRange(TraverseLeft(node));
        lst.Add(node.val);
        lst.AddRange(TraverseRight(node));

        return lst;
    }
    List<int> TraverseRight(TreeNode p)
    {
        return TraverseNode(p?.right);
    }
    List<int> TraverseLeft(TreeNode p)
    {
        return TraverseNode(p?.left);
    }

    bool CompareLists(IList<int> lst0, IList<int> lst1)
    {
        if (lst0.Count != lst1.Count)
            return false;
        var length = lst0.Count;
        for (int i = 0; i < length; i++)
        {
            if (lst0.ElementAt(i) != lst1.ElementAt((length - 1) - i))
                return false;
        }
        return true;
    }
}
