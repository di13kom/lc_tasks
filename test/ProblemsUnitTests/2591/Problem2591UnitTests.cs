using LeetCode.Problems._2591;

namespace ProblemsUnitTests._2591;

public class Problem2591UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int money, int children, int expected) td)
    {
        Assert.That(new Solution().DistMoney(td.money, td.children), Is.EqualTo(td.expected));
    }
    private static IEnumerable<(int, int, int)> GetTestCaseDatas()
    {
        yield return (20, 3, 1);
        yield return (16, 2, 2);
        yield return (8, 2, 0);
        yield return (12, 2, 0);
        yield return (6, 2, 0);
        yield return (13, 3, 1);
        yield return (1, 13, -1);
        yield return (2, 2, 0);
        yield return (13, 12, 0);
    }
}