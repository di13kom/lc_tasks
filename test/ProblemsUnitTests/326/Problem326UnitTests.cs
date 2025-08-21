using LeetCode.Problems._326;

namespace ProblemsUnitTests._326;

public class Problem326UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int n, bool expected) td)
    {
        Assert.That(new Solution().IsPowerOfThree(td.n), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int, bool)> GetTestCaseDatas()
    {
        yield return (27, true);
        yield return (0, false);
        yield return (-1, false);
        yield return (-200, false);
        yield return (int.MaxValue, false);
    }
}
