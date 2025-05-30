using NUnit.Framework;
using LeetCode.Problems._3372;

namespace ProblemsUnitTests._3372;

public class Problem3372UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(new int[] { 0, 1 }, new int[] { 0, 1 }, 0, new int[] { 1, 1 })]
    [TestCase(new int[] { 0, 1, 0, 2, 2, 3, 2, 4 }, new int[] { 0, 1, 0, 2, 0, 3, 2, 7, 1, 4, 4, 5, 4, 6 }, 2, new int[] { 9, 7, 9, 8, 8 })]
    [TestCase(new int[] { 0, 1, 0, 2, 0, 3, 0, 4 }, new int[] { 0, 1, 1, 2, 2, 3 }, 1, new int[] { 6, 3, 3, 3, 3 })]
    [TestCase(new int[] { 2, 1, 7, 3, 0, 4, 7, 5, 2, 6, 0, 2, 0, 7 }, new int[] { 3, 0, 1, 2, 5, 1, 6, 3, 9, 4, 5, 6, 7, 5, 9, 7, 8, 9 }, 7, new int[] { 18, 18, 18, 18, 18, 18, 18, 18 })]
    public void Solution_Test(int[] input1, int[] input2, int k, int[] expected)
    {
        var length2 = input2.Length;
        int[][] edges1 = TransformArray(input1);
        int[][] edges2 = TransformArray(input2);

        Assert.That(new Solution().MaxTargetNodes(edges1, edges2, k), Is.EqualTo(expected));
    }

    [TestCase(new int[] { 0, 1 }, new int[] { 0, 1 }, 0, new int[] { 1, 1 })]
    [TestCase(new int[] { 0, 1, 0, 2, 2, 3, 2, 4 }, new int[] { 0, 1, 0, 2, 0, 3, 2, 7, 1, 4, 4, 5, 4, 6 }, 2, new int[] { 9, 7, 9, 8, 8 })]
    [TestCase(new int[] { 0, 1, 0, 2, 0, 3, 0, 4 }, new int[] { 0, 1, 1, 2, 2, 3 }, 1, new int[] { 6, 3, 3, 3, 3 })]
    [TestCase(new int[] { 2, 1, 7, 3, 0, 4, 7, 5, 2, 6, 0, 2, 0, 7 }, new int[] { 3, 0, 1, 2, 5, 1, 6, 3, 9, 4, 5, 6, 7, 5, 9, 7, 8, 9 }, 7, new int[] { 18, 18, 18, 18, 18, 18, 18, 18 })]
    public void Solution0_Test(int[] input1, int[] input2, int k, int[] expected)
    {
        var length2 = input2.Length;
        int[][] edges1 = TransformArray(input1);
        int[][] edges2 = TransformArray(input2);

        Assert.That(new Solution_0().MaxTargetNodes(edges1, edges2, k), Is.EqualTo(expected));
    }

    private static int[][] TransformArray(int[] input1)
    {
        var length = input1.Length;
        var edges = new int[length / 2][];
        int j = 0;
        for (int i = 0; i < length; i += 2)
        {
            j = i / 2;
            edges[j] = new int[2] { input1[i], input1[i + 1] };
        }

        return edges;
    }
}
