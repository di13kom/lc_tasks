using System;

namespace LeetCode.Problems._3373;

public class Solution
{
    public int[] MaxTargetNodes(int[][] edges1, int[][] edges2)
    {
        List<List<int>> leftTreeNodeNeighbours = [];
        List<List<int>> rightTreeNodeNeighbours = [];

        var length1 = edges1.Length;
        int[] retVal = new int[length1 + 1];

        leftTreeNodeNeighbours = CreateMap(edges1);
        rightTreeNodeNeighbours = CreateMap(edges2);

        var lSum = TraverseNode(leftTreeNodeNeighbours, 0);
        var rSum = TraverseNode(rightTreeNodeNeighbours, 1);

        for (int i = 0; i < lSum.Length; i++)
        {
            retVal[i] = lSum[i] + rSum.Max();
        }
        return retVal;
    }

    private int[] TraverseNode(List<List<int>> dict, int k)
    {
        int[] retVal = new int[dict.Count];
        for (int i = 0; i < dict.Count; i++)
        {
            retVal[i] = k == 0 ? 1 : 0;
            for (int j = 0; j < dict[i].Count; j++)
            {
                retVal[i] += Traverse(dict, dict[i][j], k + 1, i);
            }
        }

        return retVal;
    }

    private int Traverse(List<List<int>> dict, int nodeNum, int k, int parent)
    {
        int retVal = k % 2 == 0 ? 1 : 0;

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