namespace LeetCode.Problems.Tree._501;

public class Solution
{
    Dictionary<int, int> dict = [];
    public int[] FindMode(TreeNode root)
    {

        List<int> retVal = [];
        if (root is null)
            return retVal.ToArray();

        TraverseNode(root);

        int prevCount = int.MinValue;

        foreach (var item in dict.OrderByDescending(x => x.Value))
        {
            if (item.Value >= prevCount)
            {
                retVal.Add(item.Key);
                prevCount = item.Value;
            }
            else
                break;
        }

        return retVal.ToArray();
    }

    private void TraverseNode(TreeNode root)
    {
        AppendToDictionary(root.val);

        if (root.right is not null)
            TraverseNode(root.right);

        if (root.left is not null)
            TraverseNode(root.left);

    }

    private void AppendToDictionary(int targeVl)
    {

        if (dict.TryGetValue(targeVl, out int value))
        {
            dict[targeVl]++;
        }
        else
        {
            dict.Add(targeVl, 1);
        }
    }
}
