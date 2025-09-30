using LeetCode.Problems._2169;

namespace ProblemsUnitTests._2169;

public class Problem2169UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int num1, int num2, int expected) td)
    {
        Assert.That(new Solution().CountOperations(td.num1, td.num2), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int, int, int)> GetTestCaseDatas()
    {
        yield return (2, 3, 3);
        yield return (10, 10, 1);
        yield return (77772, 6786, 32);
    }
}