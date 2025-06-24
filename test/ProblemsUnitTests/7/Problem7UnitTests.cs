using LeetCode.Problems._7;

namespace ProblemsUnitTests._7;

public class Problem7UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int input,int expected) td)
    {
        Assert.That(new Solution().Reverse(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int, int)> GetTestCaseDatas()
    {
        yield return (123, 321);
        yield return (-123, -321);
        yield return (120, 21);
        yield return (1534236469, 0);
        yield return (-1534236469, 0);
    }
}
