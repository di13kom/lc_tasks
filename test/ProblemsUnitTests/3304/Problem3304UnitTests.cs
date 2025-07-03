using LeetCode.Problems._3304;

namespace ProblemsUnitTests._3304;

public class Problem3304UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int k, char expected) td)
    {
        Assert.That(new Solution().KthCharacter(td.k), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int, char)> GetTestCaseDatas()
    {
        yield return (1, 'a');
        yield return (3, 'b');
        yield return (5, 'b');
        yield return (10, 'c');
        yield return (50, 'd');
        yield return (500, 'h');
    }
}