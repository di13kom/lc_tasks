using LeetCode.Problems._1317;

namespace ProblemsUnitTests._1317;

public class Problem1317UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Solution1Test((int n, int[] expected) td)
    {
        Assert.That(new Solution().GetNoZeroIntegers(td.n), Is.EquivalentTo(td.expected));
    }

    private static IEnumerable<(int, int[])> GetTestCaseDatas()
    {
        yield return (2, [1, 1]);
        yield return (11, [2, 9]);
        yield return (101, [2, 99]);
        yield return (1010, [11, 999]);
    }
}
