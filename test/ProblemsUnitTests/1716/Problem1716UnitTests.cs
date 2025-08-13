using LeetCode.Problems._1716;

namespace ProblemsUnitTests._1716;

public class Problem1716UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int input, int expected) td)
    {
        Assert.That(new Solution().TotalMoney(td.input), Is.EqualTo(td.expected));
    }
    private static IEnumerable<(int, int)> GetTestCaseDatas()
    {
        yield return (4, 10);
        yield return (10, 37);
        yield return (20, 96);
    }
}