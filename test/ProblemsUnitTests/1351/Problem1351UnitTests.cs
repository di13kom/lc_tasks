using LeetCode.Problems._1351;

namespace ProblemsUnitTests._1351;

public class Problem1351UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[][] input, int expected) td)
    {
        Assert.That(new Solution().CountNegatives(td.input), Is.EqualTo(td.expected));
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Solution1Test((int[][] input, int expected) td)
    {
        Assert.That(new Solution1().CountNegatives(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[][], int)> GetTestCaseDatas()
    {
        yield return ([[4, 3, 2, -1], [3, 2, 1, -1], [1, 1, -1, -2], [-1, -1, -2, -3]], 8);
        yield return ([[3, 2], [1, 0]], 0);
    }
}
