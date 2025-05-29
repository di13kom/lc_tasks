using System;

namespace LeetCode.Problems._3372;

public class Solution_0
{
    public int[] MaxTargetNodes(int[][] edges1, int[][] edges2, int k)
    {
        List<List<int>> leftTreeNodeNeighbours = [];
        List<List<int>> rightTreeNodeNeighbours = [];

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

    private int[] TraverseNode(List<List<int>> dict, int k)
    {
        int[] retVal = new int[dict.Count];
        for (int i = 0; i < dict.Count; i++)
        {
            retVal[i] = 1;
            for (int j = 0; j < dict[i].Count; j++)
            {
                retVal[i] += Traverse(dict, dict[i][j], k - 1, i);
            }
        }

        return retVal;
    }

    private int Traverse(List<List<int>> dict, int nodeNum, int k, int parent)
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

    private List<List<int>> CreateMap(int[][] targetTree)
    {
        List<List<int>> retVal = new List<List<int>>(targetTree.Length + 1);
        for (int i = 0; i < targetTree.Length + 1; i++)
        {
            retVal.Add([]);
        }
        foreach (var item in targetTree)
        {
            retVal[item[0]].Add(item[1]);
            retVal[item[1]].Add(item[0]);
        }

        return retVal;
    }
}