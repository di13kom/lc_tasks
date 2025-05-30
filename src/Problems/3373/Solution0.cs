using System;

namespace LeetCode.Problems._3373;

public class Solution0
{
    public int[] MaxTargetNodes(int[][] edges1, int[][] edges2)
    {
        List<int>[] leftTreeNodeNeighbours = [];
        List<int>[] rightTreeNodeNeighbours = [];
        int rSumMax;

        var length1 = edges1.Length;
        int[] retVal;

        leftTreeNodeNeighbours = CreateMap(edges1);
        rightTreeNodeNeighbours = CreateMap(edges2);

        var rSum = TraverseNode(rightTreeNodeNeighbours, 1, out rSumMax);
        rSumMax = Math.Max(rSumMax, rightTreeNodeNeighbours.Length - rSumMax);
        retVal = TraverseNode2(leftTreeNodeNeighbours, 0, rSumMax);

        return retVal;
    }

    private int[] TraverseNode(List<int>[] dict, int k, out int sumMax)
    {
        sumMax = 0;
        int[] retVal = new int[1];
        for (int i = 0; i < 1; i++)
        {
            retVal[i] = k == 0 ? 1 : 0;
            for (int j = 0; j < dict[i].Count; j++)
            {
                retVal[i] += Traverse(dict, dict[i][j], k + 1, i);
            }
            sumMax = retVal[i] > sumMax ? retVal[i] : sumMax;
        }

        return retVal;
    }
    private int[] TraverseNode2(List<int>[] dict, int k, int sumMax)
    {
        int[] retVal = new int[dict.Length];
        retVal[0] = 1;//self count
        for (int i = 0; i < dict[0].Count; i++)
        {
            retVal[0] += Traverse(dict, dict[0][i], k + 1, 0);//Calculate sum
        }
        retVal[0] += sumMax;

        for (int i = 0; i < dict[0].Count; i++)
        {
            FillNodesSum(dict, dict[0][i], retVal, 0, sumMax);
        }

        return retVal;
    }

    private int Traverse(List<int>[] dict, int nodeNum, int k, int parent)
    {
        int retVal = k % 2 == 0 ? 1 : 0;

        foreach (int item in dict[nodeNum])
        {
            if (item != parent)
                retVal += Traverse(dict, item, k - 1, nodeNum);
        }

        return retVal;
    }
    private void FillNodesSum(List<int>[] dict, int nodeNum, int[] retVal, int parent, int sumMax)
    {
        retVal[nodeNum] = dict.Length - (retVal[parent] - sumMax) + sumMax;
        foreach (int item in dict[nodeNum])
        {
            if (item != parent)
            {
                FillNodesSum(dict, item, retVal, nodeNum, sumMax);
            }
        }

    }

    private List<int>[] CreateMap(int[][] targetTree)
    {
        var retVal = new List<int>[targetTree.Length + 1];
        for (int i = 0; i < targetTree.Length; i++)
        {
            int u = targetTree[i][0], v = targetTree[i][1];
            (retVal[u] ??= []).Add(v);
            (retVal[v] ??= []).Add(u);
        }

        return retVal;
    }
}