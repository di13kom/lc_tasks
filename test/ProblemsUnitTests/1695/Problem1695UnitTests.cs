using LeetCode.Problems._1695;

namespace ProblemsUnitTests._1695;

public class Problem1695UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, int expected) td)
    {
        Assert.That(new Solution().MaximumUniqueSubarray(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int)> GetTestCaseDatas()
    {
        yield return ([4, 2, 4, 5, 6], 17);
        yield return ([5, 2, 1, 2, 5, 2, 1, 2, 5], 8);
        yield return ([3, 7], 10);
        yield return ([7, 7], 7);
        yield return ([1, 1, 1, 1, 2, 2, 2], 3);
    }
}