using LeetCode.Problems.Tree._96;

namespace ProblemsUnitTests.Tree._96;

public class Problem96UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int input, int expected) td)
    {
        Assert.That(new Solution().NumTrees(td.input), Is.EqualTo(td.expected));
    }
    private static IEnumerable<(int, int)> GetTestCaseDatas()
    {
        yield return (1, 1);
        yield return (3, 5);
        yield return (4, 14);
        yield return (5, 42);
        yield return (19, 1767263190);
    }
}