using LeetCode.Problems._1935;

namespace ProblemsUnitTests._1935;

public class Problem1935UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((string input, string brokenLetters, int expected) td)
    {
        Assert.That(new Solution().CanBeTypedWords(td.input, td.brokenLetters), Is.EqualTo(td.expected));
    }
    private static IEnumerable<(string, string, int)> GetTestCaseDatas()
    {
        yield return ("hello world", "ad", 1);
        yield return ("leet code", "lt", 1);
        yield return ("leet code", "e", 0);
    }
}