using LeetCode.Problems._3516;

namespace ProblemsUnitTests._3516;

public class Problem3516UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int x, int y, int z, int expected) td)
    {
        Assert.That(new Solution().FindClosest(td.x, td.y, td.z), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int, int, int, int)> GetTestCaseDatas()
    {
        yield return (2, 5, 6, 2);
        yield return (2, 7, 4, 1);
        yield return (1, 5, 3, 0);
    }
}