using LeetCode.Problems._1004;

namespace ProblemsUnitTests._1004;

[Timeout(10_000)]
public class Problem1004UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] n, int k, int expected) td)
    {
        Assert.That(new Solution().LongestOnes(td.n, td.k), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int, int)> GetTestCaseDatas()
    {
        yield return ([1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0], 2, 6);
        yield return ([0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1], 3, 10);
        yield return ([0, 0, 0, 1], 4, 4);
        yield return ([0, 0, 1, 1], 1, 3);
        yield return ([0, 0, 1, 1, 1, 0, 0], 0, 3);
        yield return ([0, 0, 0, 0], 0, 0);
    }
}
