using NUnit.Framework;
using LeetCode.Problems._2966;

namespace ProblemsUnitTests._2966;

public class Problem2966UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Test1((int[] input, int k, int[][] expected) td)
    {
        Assert.That(new Solution().DivideArray(td.input, td.k), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int, int[][])> GetTestCaseDatas()
    {
        yield return ([1, 3, 4, 8, 7, 9, 3, 5, 1], 2, [[1, 1, 3], [3, 4, 5], [7, 8, 9]]);
        yield return ([2, 4, 2, 2, 5, 2], 2, []);
        yield return ([4, 2, 9, 8, 2, 12, 7, 12, 10, 5, 8, 5, 5, 7, 9, 2, 5, 11], 2, [[2, 2, 2], [4, 5, 5], [5, 5, 7], [7, 8, 8], [9, 9, 10], [11, 12, 12]]);
        yield return ([3, 3, 3], 2, [[3, 3, 3]]);
        yield return ([3, 2, 100000], 2, []);
        yield return ([4, 3, 4, 1, 9, 1, 1, 6, 5], 2, []);//bad[[1, 1, 1], [3, 4, 4], [5, 6, 9]]
        yield return ([8, 1, 8, 6, 8, 1, 3, 9, 100000], 2, []);//bad[[1, 1, 3], [6, 8, 8], [8, 9, 100000]]
    }
}