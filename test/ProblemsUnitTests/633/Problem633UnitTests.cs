using LeetCode.Problems._633;

namespace ProblemsUnitTests._633;

public class Problem633UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int input, bool expected) td)
    {
        Assert.That(new Solution().JudgeSquareSum(td.input), Is.EqualTo(td.expected));
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Solution1Test((int input, bool expected) td)
    {
        Assert.That(new Solution1().JudgeSquareSum(td.input), Is.EqualTo(td.expected));//Wrong solution. just test;
    }

    private static IEnumerable<(int, bool)> GetTestCaseDatas()
    {
        yield return (2, true);
        yield return (5, true);
        yield return (3, false);
        yield return (8, true);
        yield return (2001, false);
        yield return (1763, false);
        yield return (400, true);
        yield return (423, false);
        yield return (425, true);
        yield return (9, true);
        yield return (29, true);
        yield return (30, false);
        yield return (123456, false);
        yield return (0, true);
        yield return (1256, true);
        yield return (2147483647, false);
        yield return (1000000000, true);//1200+31600
    }
}