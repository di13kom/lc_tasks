using LeetCode.Problems._2327;

namespace ProblemsUnitTests._2327;

public class Problem2327UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int n, int delay, int forgets, int expected) td)
    {
        Assert.That(new Solution().PeopleAwareOfSecret(td.n, td.delay, td.forgets), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int, int, int, int)> GetTestCaseDatas()
    {
        yield return (6, 2, 4, 5);
        yield return (4, 1, 3, 6);
        yield return (1000, 5, 10, 743819361);
        yield return (987, 7, 987, 766374848);
        yield return (100, 5, 10, 108223204);
        yield return (289, 7, 23, 790409951);
    }
}
