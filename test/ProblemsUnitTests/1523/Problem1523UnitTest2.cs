using LeetCode.Problems._1523;

namespace ProblemsUnitTests._1523;

public class Problem1523UnitTest2
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int high, int low, int expected) td)
    {
        Assert.That(new Solution().CountOdds(td.high, td.low), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int, int, int)> GetTestCaseDatas()
    {
        yield return (3, 7, 3);
        yield return (8, 10, 1);
        yield return (4, 9, 3);
        yield return (6, 10, 2);
        yield return (1, 10, 5);
        yield return (356, 967597, 483621);
    }
}
