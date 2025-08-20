using LeetCode.Problems._869;

namespace ProblemsUnitTests._869;

[Timeout(10_000)]
public class Problem869UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int input, bool expected) td)
    {
        Assert.That(new Solution().ReorderedPowerOf2(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int, bool)> GetTestCaseDatas()
    {
        yield return (1, true);
        yield return (10, false);
        yield return (1892, true);
        yield return (101237, true);
        yield return (1022579, true);
        yield return (102356789, true);
        yield return (1204, true);
        yield return (1240, true);
        yield return (1000000000, false);
        yield return (999999999, false);
    }
}
