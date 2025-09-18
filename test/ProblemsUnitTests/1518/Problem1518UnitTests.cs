using LeetCode.Problems._1518;

namespace ProblemsUnitTests._1518;

public class Problem1518UnitTests
{
    [SetUp]
    public void Setup()
    {
    }


    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int numBottles, int numExchange, int expected) td)
    {
        Assert.That(new Solution().NumWaterBottles(td.numBottles, td.numExchange), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int, int, int)> GetTestCaseDatas()
    {
        yield return (9, 3, 13);
        yield return (15, 4, 19);
    }
}
