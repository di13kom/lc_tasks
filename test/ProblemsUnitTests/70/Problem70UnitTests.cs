using LeetCode.Problems._70;

namespace ProblemsUnitTests._70;

public class Problem70UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int input, int expected) td)
    {
        Assert.That(new Solution().ClimbStairs(td.input), Is.EqualTo(td.expected));
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Solution1Test((int input, int expected) td)
    {
        Assert.That(new Solution1().ClimbStairs(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int, int)> GetTestCaseDatas()
    {
        yield return (2, 2);
        yield return (3, 3);
        yield return (4, 5);
        yield return (5, 8);
        yield return (6, 13);
        yield return (7, 21);
        yield return (15, 987);
        yield return (30, 1346269);
        yield return (44, 1134903170);
    }
}