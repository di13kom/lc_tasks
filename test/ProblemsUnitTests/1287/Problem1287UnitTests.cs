using LeetCode.Problems._1287;

namespace ProblemsUnitTests._1287;

public class Problem1287UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, int expected) td)
    {
        Assert.That(new Solution().FindSpecialInteger(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int)> GetTestCaseDatas()
    {
        yield return ([1, 2, 2, 6, 6, 6, 6, 7, 10], 6);
        yield return ([1, 1], 1);
    }
}