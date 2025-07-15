using LeetCode.Problems._3136;

namespace ProblemsUnitTests._3136;

public class Problem3136UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((string input, bool expected) td)
    {
        Assert.That(new Solution().IsValid(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(string, bool)> GetTestCaseDatas()
    {
        yield return ("234Adas", true);
        yield return ("234Adx", true);
        yield return ("4aDx", true);
        yield return ("b3", false);
        yield return ("a3$e", false);
        yield return ("aya", true);
    }
}