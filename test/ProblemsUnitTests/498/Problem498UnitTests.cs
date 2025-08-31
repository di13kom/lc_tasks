using LeetCode.Problems._498;

namespace ProblemsUnitTests._498;

public class Problem498UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[][] mat, int[] expected) td)
    {
        Assert.That(new Solution().FindDiagonalOrder(td.mat), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[][], int[])> GetTestCaseDatas()
    {
        yield return ([[1, 2, 3], [4, 5, 6], [7, 8, 9]], [1, 2, 4, 7, 5, 3, 6, 8, 9]);
        yield return ([[1, 2], [3, 4]], [1, 2, 3, 4]);
        yield return ([[1, 2], [3, 4], [6, 7]], [1, 2, 3, 6, 4, 7]);
        yield return ([[1, 2, 3], [4, 5, 6]], [1, 2, 4, 5, 3, 6]);
        yield return ([[1, 2, 3], [4, 5, 6]], [1, 2, 4, 5, 3, 6]);
        yield return ([[-7], [14], [0], [88], [-65]], [-7, 14, 0, 88, -65]);
    }
}
