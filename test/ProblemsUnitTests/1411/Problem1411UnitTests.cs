using LeetCode.Problems._1411;

namespace ProblemsUnitTests._1411;

public class Problem1411UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int input, int expected) td)
    {
        Assert.That(new Solution().NumOfWays(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int, int)> GetTestCaseDatas()
    {
        yield return (1, 12);
        yield return (2, 54);
        yield return (3, 246);
        yield return (9, 2215902);
        yield return (11, 46107966);
        yield return (12, 210323922);
        yield return (13, 959403678);
        yield return (14, 376370518);
        yield return (15, 963045241);
        yield return (30, 462032897);
        yield return (55, 921443386);
        yield return (5000, 30228214);
    }
}
