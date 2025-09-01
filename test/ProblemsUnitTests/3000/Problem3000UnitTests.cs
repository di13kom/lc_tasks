using LeetCode.Problems._3000;

namespace ProblemsUnitTests._3000;

public class Problem3000UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[][] n, int expected) td)
    {
        Assert.That(new Solution().AreaOfMaxDiagonal(td.n), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[][], int)> GetTestCaseDatas()
    {
        yield return ([[9, 3], [8, 6]], 48);
        yield return ([[3, 4], [4, 3]], 12);
        yield return ([[3, 4], [4, 3], [5, 6]], 30);
    }
}
