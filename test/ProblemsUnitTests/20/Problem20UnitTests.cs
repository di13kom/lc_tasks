using LeetCode.Problems._20;

namespace ProblemsUnitTests._20;

public class Problem20UnitTests
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
        yield return ("()", true);
        yield return ("()[]{}", true);
        yield return ("(]", false);
        yield return ("([])", true);
        yield return (")(", false);
    }
}
