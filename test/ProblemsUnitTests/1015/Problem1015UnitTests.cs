using LeetCode.Problems._1015;

namespace ProblemsUnitTests._1015;

public class Problem1015UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int k, int expected) td)
    {
        Assert.That(new Solution().SmallestRepunitDivByK(td.k), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int, int)> GetTestCaseDatas()
    {
        yield return (1, 1);
        yield return (2, -1);
        yield return (3, 3);
        yield return (5, -1);
        yield return (6, -1);
        yield return (7, 6);
        yield return (8, -1);
        yield return (9, 9);
        yield return (15, -1);
        yield return (123, 15);
        yield return (333, 9);
        yield return (1479, 336);
        yield return (9765, -1);
        yield return (12357, 6174);
    }
}
