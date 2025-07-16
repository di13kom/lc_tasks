using LeetCode.Problems._69;

namespace ProblemsUnitTests._69;

public class Problem69UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int input, int expected) td)
    {
        Assert.That(new Solution().MySqrt(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int, int)> GetTestCaseDatas()
    {
        yield return (4, 2);
        yield return (8, 2);
        yield return (15, 3);
        yield return (16, 4);
        yield return (17, 4);
        yield return (18, 4);
        yield return (19, 4);
        yield return (20, 4);
        yield return (128, 11);
        yield return (1025, 32);
        yield return (28765, 169);
        yield return (99999, 316);
        yield return (int.MaxValue, 46340);

    }
}