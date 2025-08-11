using LeetCode.Problems._2038;

namespace ProblemsUnitTests._2038;

public class Problem2038UnitTest2
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((string input, bool expected) td)
    {
        Assert.That(new Solution().WinnerOfGame(td.input), Is.EqualTo(td.expected));
    }
    private static IEnumerable<(string, bool)> GetTestCaseDatas()
    {
        yield return ("AAABABB", true);
        yield return ("AA", false);
        yield return ("ABBBBBBBAAA", false);
    }
}