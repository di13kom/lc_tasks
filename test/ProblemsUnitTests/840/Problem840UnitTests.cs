using LeetCode.Problems._840;

namespace ProblemsUnitTests._840;

public class Problem840UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[][] input, int expected) td)
    {
        Assert.That(new Solution().NumMagicSquaresInside(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[][], int)> GetTestCaseDatas()
    {
        yield return ([[4, 3, 8, 4], [9, 5, 1, 9], [2, 7, 6, 2]], 1);
        yield return ([[8]], 0);
        yield return ([[1, 1, 1], [1, 1, 1], [1, 1, 1]], 0);
        yield return ([[7, 0, 5], [2, 4, 6], [3, 8, 1]], 0);
        yield return ([[4, 3, 8, 4], [9, 5, 1, 9], [2, 7, 6, 2], [4, 3, 8, 1], [1, 6, 7, 5]], 1);
    }
}
