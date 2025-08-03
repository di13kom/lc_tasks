using LeetCode.Problems._3487;

namespace ProblemsUnitTests._3487;

public class Problem3487UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, int expected) td)
    {
        Assert.That(new Solution().MaxSum(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int)> GetTestCaseDatas()
    {
        yield return ([1, 2, 3, 4, 5], 15);
        yield return ([1, 1, 0, 1, 1], 1);
        yield return ([1, 2, -1, -2, 1, 0, -1], 3);
    }
}