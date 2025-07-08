using LeetCode.Problems._58;

namespace ProblemsUnitTests._58;

public class Problem58UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((string input, int expected) td)
    {
        Assert.That(new Solution().LengthOfLastWord(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(string, int)> GetTestCaseDatas()
    {
        yield return ("Hello World", 5);
        yield return ("   fly me   to   the moon  ", 4);
        yield return ("luffy is still joyboy", 6);
    }
}