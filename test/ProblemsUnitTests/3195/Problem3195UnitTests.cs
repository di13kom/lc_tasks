using LeetCode.Problems._3195;

namespace ProblemsUnitTests._3195;

public class Problem3195UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[][] n, int expected) td)
    {
        Assert.That(new Solution().MinimumArea(td.n), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[][], int)> GetTestCaseDatas()
    {
        yield return ([[1]], 1);
        yield return ([[0, 1]], 1);
        yield return ([[0, 1, 0], [1, 0, 1]], 6);
        yield return ([[1, 0], [0, 0]], 1);
        yield return ([[0, 1, 0, 0, 0, 0, 0, 0, 0],
                       [0, 0, 0, 0, 0, 1, 1, 0, 0]], 12);
        yield return ([[0, 1, 0, 0, 0, 0, 0, 0, 1],
                       [0, 0, 0, 0, 0, 1, 1, 0, 0]], 16);
        yield return ([[0, 1, 0, 0, 0, 0, 0, 0, 1],
                       [1, 0, 0, 0, 0, 1, 1, 0, 0]], 18);
        yield return ([[0, 1, 0, 0, 0, 1, 0, 0, 1],
                       [1, 0, 0, 0, 0, 1, 1, 0, 0]], 18);
        yield return ([[0, 0, 0],
                       [0, 0, 0],
                       [0, 0, 0],
                       [0, 0, 1]], 1);
    }
}
