using LeetCode.Problems._2221;

namespace ProblemsUnitTests._2221;

public class Problem2221UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, int expected) td)
    {
        Assert.That(new Solution().TriangularSum(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int)> GetTestCaseDatas()
    {
        yield return ([1, 2, 3, 4], 0);
        yield return ([1, 2, 3, 4, 5], 8);
        yield return ([5], 5);
    }
}
