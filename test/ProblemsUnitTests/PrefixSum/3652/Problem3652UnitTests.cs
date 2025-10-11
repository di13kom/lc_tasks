using LeetCode.Problems.PrefixSum._3652;

namespace ProblemsUnitTests.PrefixSum._3652;

public class Problem3652UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] prices, int[] strategies, int k, long expected) td)
    {
        Assert.That(new Solution().MaxProfit(td.prices, td.strategies, td.k), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int[], int, long)> GetTestCaseDatas()
    {
        yield return ([4, 2, 8], [-1, 0, 1], 2, 10);
        yield return ([5, 4, 3], [1, 1, 0], 2, 9);
        yield return ([5, 8], [-1, -1], 2, 8);
        yield return ([4, 7, 13], [-1, -1, 0], 2, 9);
    }
}
