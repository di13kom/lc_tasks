using NUnit.Framework;
using LeetCode.Problems._3373;

namespace ProblemsUnitTests._3373;

[Timeout(10000)]
public class Problem3373UnitTests
{

    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Solution_Tests(int[] input1, int[] input2, int[] expected)
    {
        int[][] edges1 = FixArray(input1);
        int[][] edges2 = FixArray(input2);

        Assert.That(new Solution().MaxTargetNodes(edges1, edges2), Is.EqualTo(expected));
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Solution0_Tests(int[] input1, int[] input2, int[] expected)
    {
        int[][] edges1 = FixArray(input1);
        int[][] edges2 = FixArray(input2);

        Assert.That(new Solution0().MaxTargetNodes(edges1, edges2), Is.EqualTo(expected));
    }

    private static int[][] FixArray(int[] input1)
    {
        var length = input1.Length;
        var retVal = new int[length / 2][];
        int j = 0;
        for (int i = 0; i < length; i += 2)
        {
            j = i / 2;
            retVal[j] = [input1[i], input1[i + 1]];
        }

        return retVal;
    }

    private static IEnumerable<int[][]> GetTestCaseDatas()
    {
        yield return new int[][]{
            [0, 1],
            [0, 1],
            [2, 2]
        };

        yield return new int[][]
        {
            [0, 1, 0, 2, 2, 3, 2, 4],
            [0, 1, 0, 2, 0, 3, 2, 7, 1, 4, 4, 5, 4, 6],
            [8, 7, 7, 8, 8]
        };

        yield return new int[][]
        {
            [2, 1, 7, 3, 0, 4, 7, 5, 2, 6, 0, 2, 0, 7],
            [3, 0, 1, 2, 5, 1, 6, 3, 9, 4, 5, 6, 7, 5, 9, 7, 8, 9],
            [11, 11, 9, 11, 9, 11, 11, 9]
        };

        yield return new int[][]
        {
            [0, 1, 0, 2, 0, 3, 0, 4],
            [0, 1, 1, 2, 2, 3],
            [3, 6, 6, 6, 6]
        };

        //yield return new int[][] { Enumerable.Range(0, 6472).Zip(Enumerable.Range(1, 6472), (first, second) => new int[] { first, second }).SelectMany(x => x).ToArray(),
        //Enumerable.Range(0, 8732).Zip(Enumerable.Range(1,8372),(f,s)=> new int []{f,s}).SelectMany(x =>x).ToArray(),
        //Enumerable.Range(0, 6472).ToArray()
        //};


        //yield return new int[][] { Enumerable.Repeat(0, 6472).Zip(Enumerable.Range(1, 6472), (first, second) => new int[] { first, second }).SelectMany(x => x).ToArray(),
        //Enumerable.Range(0, 8732).Zip(Enumerable.Range(1,8372),(f,s)=> new int []{f,s}).SelectMany(x =>x).ToArray(),
        //Enumerable.Range(0, 6472).ToArray(),
        //};
    }
}
