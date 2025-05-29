using System;

namespace LeetCode.Problems._3372;

public class Solution
{
    public int[] MaxTargetNodes(int[][] edges1, int[][] edges2, int k)
    {
        Dictionary<int, List<int>> leftTreeNodeNeighbours = [];
        Dictionary<int, List<int>> rightTreeNodeNeighbours = [];

        var length1 = edges1.Length;
        int[] retVal = new int[length1 + 1];

        leftTreeNodeNeighbours = CreateMap(edges1);
        rightTreeNodeNeighbours = CreateMap(edges2);

        var lSum = TraverseNode(leftTreeNodeNeighbours, k);
        var rSum = TraverseNode(rightTreeNodeNeighbours, k - 1);

        for (int i = 0; i < lSum.Length; i++)
        {
            retVal[i] = lSum[i] + (k - 1 >= 0 ? rSum.Max() : 0);
        }
        return retVal;
    }

    private int[] TraverseNode(Dictionary<int, List<int>> dict, int k)
    {
        int[] retVal = new int[dict.Keys.Count];
        foreach (var item in dict)
        {
            retVal[item.Key] = 1;
            for (int i = 0; i < item.Value.Count; i++)
            {
                retVal[item.Key] += Traverse(dict, item.Value[i], k - 1, item.Key);
            }
        }

        return retVal;
    }

    private int Traverse(Dictionary<int, List<int>> dict, int nodeNum, int k, int parent)
    {
        int retVal = 1;
        if (k == 0)
            return 1;
        if (k <= 0)
            return 0;

        foreach (int item in dict[nodeNum])
        {
            if (item != parent)
                retVal += Traverse(dict, item, k - 1, nodeNum);
        }

        return retVal;
    }

    private Dictionary<int, List<int>> CreateMap(int[][] targetTree)
    {
        Dictionary<int, List<int>> retVal = [];
        for (int i = 0; i < targetTree.Length; i++)
        {
            if (!retVal.TryAdd(targetTree[i][0], [targetTree[i][1]]))
            {
                retVal[targetTree[i][0]].Add(targetTree[i][1]);
            }
            if (!retVal.TryAdd(targetTree[i][1], [targetTree[i][0]]))
            {
                retVal[targetTree[i][1]].Add(targetTree[i][0]);
            }
        }

        return retVal;
    }
}