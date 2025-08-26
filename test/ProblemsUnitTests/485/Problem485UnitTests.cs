using LeetCode.Problems._485;

namespace ProblemsUnitTests._485;

public class Problem485UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] n, int expected) td)
    {
        Assert.That(new Solution().FindMaxConsecutiveOnes(td.n), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int)> GetTestCaseDatas()
    {
        yield return ([1, 1, 0, 1, 1, 1], 3);
        yield return ([1, 0, 1, 1, 0, 1], 2);
    }
}
