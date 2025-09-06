using LeetCode.Problems._1304;

namespace ProblemsUnitTests._1304;

public class Problem1304UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int input1, int expected) td)
    {
        Assert.That(new Solution().SumZero(td.input1).Sum(), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int, int)> GetTestCaseDatas()
    {
        yield return (5, 0);
        yield return (3, 0);
        yield return (1, 0);
    }
}