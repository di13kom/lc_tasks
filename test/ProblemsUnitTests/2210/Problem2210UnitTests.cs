using LeetCode.Problems._2210;

namespace ProblemsUnitTests._2210;

public class Problem2210UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, int expected) td)
    {
        Assert.That(new Solution().CountHillValley(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int)> GetTestCaseDatas()
    {
        yield return ([2, 4, 1, 1, 6, 5], 3);
        yield return ([6, 6, 5, 5, 4, 1], 0);
        yield return ([5, 5, 6, 6, 4, 1], 1);
        yield return ([2, 4, 5, 1, 6, 5], 3);
        yield return ([2, 2, 2, 2, 2, 2], 0);
        yield return ([2, 2, 2, 1, 1, 1], 0);
        yield return ([2, 3, 4, 5, 6, 1], 1);
        yield return ([2, 3, 4, 5, 6, 6], 0);
        yield return ([2, 3, 4, 5, 6, 7], 0);
        yield return ([2, 4, 4, 4, 4, 1], 1);
    }
}