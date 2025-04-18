using LeetCode.Problems.Tree;

namespace LeetCode.Problems.Tree;

public class TreeNodeFactory
{
    TreeNode retVal;
    List<TreeNode> treeNodes;
    int currentDepth = 0;
    public TreeNode CreateBinaryTreeNodeByArray(int?[] array)
    {
        treeNodes = [];
        var IscreateNodeSuccess = true;
        while (IscreateNodeSuccess)
        {
            IscreateNodeSuccess = CreateNode(array);
        }
        ;


        return retVal;
    }
    private bool CreateNode(int?[] array)
    {
        int curQuantity = (int)Math.Pow(2, currentDepth);

        if (curQuantity >= array.Length)
            return false;

        for (int i = curQuantity - 1; i < curQuantity * 2 - 1; i++)
        {
            var curValue = array[i];
            //if (curValue != null)
            //{
            var nd = new TreeNode(curValue.Value);
            treeNodes.Add(nd);
            FindParent(nd);
            //}
        }

        currentDepth++;

        return true;
    }

    private void FindParent(TreeNode node)
    {
        var prevDepthLevel = currentDepth - 1;
        if (prevDepthLevel == -1)
            retVal = node;
        int preQuantity = (int)Math.Pow(2, prevDepthLevel);
        for (int i = preQuantity - 1; i < preQuantity * 2 - 1; i++)
        {
            var cNode = treeNodes.ElementAt(i);
            if (cNode == null)
                continue;
            if (cNode.right is null)
            {
                cNode.right = node;
                break;
            }
            else if (cNode.left is null)
            {
                cNode.left = node;
                break;
            }
        }
    }

    /*
    public TreeNode CreateBinaryTreeNodeByArrayWithIteration(int?[] array)
    {
        if (array is null || array[0] is null)
            return null;
        TreeNode retVal = new(array[0].Value);
        var curNode = retVal;
        array = array[1..];
        int curDepth = 1;
        int curNodeNumInDepth = 1;

        for (int i = 1, j = 2; i < array.Length; i += 2, j += 2)
        {
            curNode = FindNode(retVal);
            curNode.left = array[i].HasValue ? new(array[i].Value) : null;
            curNode.right = array[j].HasValue ? new(array[j].Value) : null;
        }

        return retVal;

    }

    private TreeNode FindNode(TreeNode targetTree)
    {
        TreeNode curNode = targetTree;
        int curQuantity = (int)Math.Pow(2, currentDepth);
        int i;
        if (i/2 == 1)
            curNode = curNode.left;
        else
            curNode = curNode.right;

    }
    */
}
