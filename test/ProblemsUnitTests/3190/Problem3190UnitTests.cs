using LeetCode.Problems._3190;

namespace ProblemsUnitTests._3190;

public class Problem3190UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, int expected) td)
    {
        Assert.That(new Solution().MinimumOperations(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int)> GetTestCaseDatas()
    {
        yield return ([1, 2, 3, 4], 3);
        yield return ([3, 6, 9], 0);
    }
}
