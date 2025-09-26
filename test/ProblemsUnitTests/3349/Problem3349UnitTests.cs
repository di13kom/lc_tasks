using LeetCode.Problems._3349;

namespace ProblemsUnitTests._3349;

public class Problem3349UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((IList<int> input, int k, bool expected) td)
    {
        Assert.That(new Solution().HasIncreasingSubarrays(td.input, td.k), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(IList<int>, int, bool)> GetTestCaseDatas()
    {
        yield return ([2, 5, 7, 8, 9, 2, 3, 4, 3, 1], 3, true);
        yield return ([1, 2, 3, 4, 4, 4, 4, 5, 6, 7], 5, false);
        yield return ([1, 2, 3, 4, 5, 6, 7, 8], 4, true);
        yield return ([0, 4, 16, 20, -6], 2, true);
        yield return ([5, 8, -2, -1], 2, true);
        yield return ([-15, -13, 4, 7], 2, true);
        yield return ([-15, 19], 1, true);
        yield return ([-15, 19], 1, true);
        yield return ([6, 13, -17, -20, 2], 2, false);
        yield return ([0, -10, 9, 12, -19, -18, 20], 2, true);
        yield return ([-10, 14, 17], 1, true);
        yield return ([-14, 11, 18, 16, -13], 2, false);
        yield return ([11, 17, -16, -18, -6, 12, 6, 8], 2, true);
    }
}
