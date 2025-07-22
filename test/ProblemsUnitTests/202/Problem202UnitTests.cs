using LeetCode.Problems._202;

namespace ProblemsUnitTests._202;

public class Problem202UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int input, bool expected) td)
    {
        Assert.That(new Solution().IsHappy(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int, bool)> GetTestCaseDatas()
    {
        yield return (19, true);
        yield return (2, false);
        yield return (7, true);
        yield return (4, false);
        yield return (1111111, true);
    }
}