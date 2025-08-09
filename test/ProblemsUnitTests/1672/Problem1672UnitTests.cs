using LeetCode.Problems._1672;

namespace ProblemsUnitTests._1672;

public class Problem1672UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[][] accounts, int expected) td)
    {
        Assert.That(new Solution().MaximumWealth(td.accounts), Is.EqualTo(td.expected));
    }
    private static IEnumerable<(int[][], int)> GetTestCaseDatas()
    {
        yield return ([[1, 2, 3], [3, 2, 1]], 6);
        yield return ([[1, 5], [7, 3], [3, 5]], 10);
        yield return ([[2, 8, 7], [7, 1, 3], [1, 9, 5]], 17);

    }
}
