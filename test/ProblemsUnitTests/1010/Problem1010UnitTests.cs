using LeetCode.Problems._1010;

namespace ProblemsUnitTests._1010;

public class Problem1010UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] time, int expected) td)
    {
        Assert.That(new Solution().NumPairsDivisibleBy60(td.time), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int)> GetTestCaseDatas()
    {
        yield return ([30, 20, 150, 100, 40], 3);
        yield return ([60, 60, 60], 3);
        yield return ([60, 60, 60, 60, 60], 10);
    }
}