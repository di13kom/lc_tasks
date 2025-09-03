using LeetCode.Problems._1551;

namespace ProblemsUnitTests._1551;

public class Problem1551UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int input, int expected) td)
    {
        Assert.That(new Solution().MinOperations(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int, int)> GetTestCaseDatas()
    {
        yield return (3, 2);
        yield return (6, 9);
    }
}
