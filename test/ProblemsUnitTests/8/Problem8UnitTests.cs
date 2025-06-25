using LeetCode.Problems._8;

namespace ProblemsUnitTests._8;

public class Problem8UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((string input, int expected) td)
    {
        Assert.That(new Solution().MyAtoi(td.input), Is.EqualTo(td.expected));
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Solution1Test((string input, int expected) td)
    {
        Assert.That(new Solution1().MyAtoi(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(string, int)> GetTestCaseDatas()
    {
        yield return ("42", 42);
        yield return (" -042", -42);
        yield return ("1337c0d3", 1337);
        yield return ("0-1", 0);
        yield return ("words and 987", 0);
        yield return ("--1", 0);
        yield return ("++1", 0);
        yield return ("+-1", 0);
        yield return ("+1", 1);
        yield return ("-00000085", -85);
        yield return ("9646324351", int.MaxValue);
        yield return ("-9646324351", int.MinValue);
        yield return ("  0000000000012345678", 12345678);
        yield return ("2147483648", 2147483647);
        yield return ("-2147483647", -2147483647);
    }
}
