using LeetCode.Problems._2044;

namespace ProblemsUnitTests._2044;

public class Problem2044UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, int expected) td)
    {
        Assert.That(new Solution().CountMaxOrSubsets(td.input), Is.EqualTo(td.expected));
    }
    private static IEnumerable<(int[], int)> GetTestCaseDatas()
    {
        yield return ([3, 1], 2);
        yield return ([2, 2, 2], 7);
        yield return ([3, 2, 1, 5], 6);
    }
}
