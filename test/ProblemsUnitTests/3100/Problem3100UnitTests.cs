using LeetCode.Problems._3100;

namespace ProblemsUnitTests._3100;

public class Problem3100UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int numBottles, int numExchange, int expected) td)
    {
        Assert.That(new Solution().MaxBottlesDrunk(td.numBottles, td.numExchange), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int, int, int)> GetTestCaseDatas()
    {
        yield return (13, 6, 15);
        yield return (10, 3, 13);
        yield return (1, 1, 2);
        yield return (10, 2, 13);
        yield return (19, 4, 23);
        yield return (25, 10, 27);
        yield return (30, 3, 36);
    }
}
