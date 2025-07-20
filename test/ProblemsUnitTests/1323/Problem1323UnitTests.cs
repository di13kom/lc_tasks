using LeetCode.Problems._1323;

namespace ProblemsUnitTests._1323;

public class Problem1323UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int input, int expected) td)
    {
        Assert.That(new Solution().Maximum69Number(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int, int)> GetTestCaseDatas()
    {
        yield return (9669, 9969);
        yield return (9996, 9999);
        yield return (9999, 9999);
        yield return (696, 996);
        yield return (96, 99);
        yield return (6, 9);
        yield return (9, 9);
    }
}