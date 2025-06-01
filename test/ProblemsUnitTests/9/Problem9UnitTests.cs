using NUnit.Framework;
using LeetCode.Problems._9;

namespace ProblemsUnitTests._9;

public class Problem9UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Solution1Test((int input, bool expected) td)
    {
        Assert.That(new Solution1().IsPalindrome(td.input), Is.EqualTo(td.expected));
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int input, bool expected) td)
    {
        Assert.That(new Solution().IsPalindrome(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int, bool)> GetTestCaseDatas()
    {
        yield return (121, true);
        yield return (-121, false);
        yield return (10, false);
        yield return (5444, false);
        yield return (5445, true);
        yield return (123321, true);
        yield return (20455402, true);
        yield return (20456402, false);
        yield return (2046402, true);
    }
}