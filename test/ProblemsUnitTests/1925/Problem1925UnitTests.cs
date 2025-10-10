using LeetCode.Problems._1925;

namespace ProblemsUnitTests._1925;

public class Problem1925UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int n, int expected) td)
    {
        Assert.That(new Solution().CountTriples(td.n), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int, int)> GetTestCaseDatas()
    {
        yield return (5, 2);
        yield return (10, 4);
        yield return (1, 0);
        yield return (150, 178);
        yield return (249, 324);
        yield return (19, 10);
        yield return (193, 238);
        yield return (148, 172);
        yield return (239, 312);
        yield return (250, 330);
    }
}
