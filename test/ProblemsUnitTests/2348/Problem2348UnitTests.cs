using LeetCode.Problems._2348;

namespace ProblemsUnitTests._2348;

public class Problem2348UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] n, long expected) td)
    {
        Assert.That(new Solution().ZeroFilledSubarray(td.n), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], long)> GetTestCaseDatas()
    {
        yield return ([1, 3, 0, 0, 2, 0, 0, 4], 6);
        yield return ([0, 0, 0, 2, 0, 0], 9);
        yield return ([2, 10, 2019], 0);
        yield return ([0, 0, 1, 0, 0, 0, 2, 0, 0, 3, 0, 0, 0, 0, 4], 22);
        yield return ([5, 0, 0, 0, 0, 0, 6, 7, 0, 0, 0, 8, 0, 0], 24);
        yield return ([0, 0, 0, 0, 0, 0, 0, 0, 0, 0], 55);
    }
}
