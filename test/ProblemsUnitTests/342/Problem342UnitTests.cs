using LeetCode.Problems._342;

namespace ProblemsUnitTests._342;

public class Problem342UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int n, bool expected) td)
    {
        Assert.That(new Solution().IsPowerOfFour(td.n), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int, bool)> GetTestCaseDatas()
    {
        yield return (16, true);
        yield return (5, false);
        yield return (1, true);
        yield return (8, false);
        yield return (0, false);
    }
}
