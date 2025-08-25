using LeetCode.Problems._1493;

namespace ProblemsUnitTests._1493;

public class Problem1493UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] n, int expected) td)
    {
        Assert.That(new Solution().LongestSubarray(td.n), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int)> GetTestCaseDatas()
    {
        yield return ([0, 0, 1, 1], 2);
        yield return ([1, 1, 0, 1], 3);
        yield return ([1, 1, 1], 2);
        yield return ([0, 1, 1, 1, 0, 1, 1, 0, 1], 5);
        yield return ([0, 1, 1, 1, 1, 1, 1, 0, 1], 7);
        yield return ([0, 1, 1, 1, 1, 1, 1, 0, 0], 6);
        yield return ([1, 0, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1, 1, 0, 1, 1, 1], 7);
        yield return ([0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0], 0);
        yield return ([1, 1, 0, 1, 1, 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 1], 10);
        yield return ([1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1], 13);
        yield return ([0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0], 2);
        yield return ([1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1], 2);
        yield return ([0, 1, 1, 1, 0, 0, 1, 1, 1, 1, 0, 1, 1, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1], 8);
        yield return ([1, 1, 0, 0, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1, 1, 0, 1, 1, 0, 1, 1], 7);
    }
}
