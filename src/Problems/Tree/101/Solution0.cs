using System.Globalization;

namespace LeetCode.Problems.Tree._101;

public class Solution0
{
    public bool IsSymmetric(TreeNode root)
    {
        bool retVal;
        IList<IList<int?>> lstLeft = [[]];
        IList<IList<int?>> lstRight = [[]];
        TraverseNode(root?.left, lstLeft, 0);
        TraverseNode(root?.right, lstRight, 0);


        return CompareLists(lstLeft, lstRight);

        void TraverseNode(TreeNode node, IList<IList<int?>> curList, int curLevel)
        {
            curList[curLevel].Add(node?.val);
            if (node is null)
            {
                return;
            }
            if (curList.Count < (curLevel + 2))
                curList.Add([]);

            TraverseNode(node?.left, curList, curLevel + 1);
            TraverseNode(node?.right, curList, curLevel + 1);

        }

        bool CompareLists(IList<IList<int?>> leftSubTree, IList<IList<int?>> rightSubTree)
        {
            if (leftSubTree.Count != rightSubTree.Count)
                return false;
            var length = leftSubTree.Count;
            for (int i = 0; i < length; i++)
            {
                if (leftSubTree.ElementAt(i).Count != rightSubTree.ElementAt(i).Count)
                    return false;
                var levelListLength = leftSubTree.ElementAt(i).Count;
                for (int j = 0; j < levelListLength; j++)
                {
                    if (leftSubTree[i][j] != rightSubTree[i][(levelListLength - 1) - j])
                        return false;
                }
            }
            return true;
        }
    }
}