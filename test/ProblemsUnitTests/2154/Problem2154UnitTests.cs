using LeetCode.Problems._2154;

namespace ProblemsUnitTests._2154;

public class Problem2154UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, int original, int expected) td)
    {
        Assert.That(new Solution().FindFinalValue(td.input, td.original), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int, int)> GetTestCaseDatas()
    {
        yield return ([5, 3, 6, 1, 12], 3, 24);
        yield return ([2, 7, 9], 4, 4);
    }
}
