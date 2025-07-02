using LeetCode.Problems._3330;

namespace ProblemsUnitTests._3330;

public class Problem3330UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((string input, int expected) td)
    {
        Assert.That(new Solution().PossibleStringCount(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(string, int)> GetTestCaseDatas()
    {
        yield return ("abbcccc", 5);
        yield return ("abcd", 1);
        yield return ("aaaa", 4);
        yield return ("a", 1);
        yield return ("ab", 1);
        yield return ("ere", 1);
    }
}