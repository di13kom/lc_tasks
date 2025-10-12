using LeetCode.Problems._944;

namespace ProblemsUnitTests._944;

public class Problem944UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((string[] input, int expected) td)
    {
        Assert.That(new Solution().MinDeletionSize(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(string[], int)> GetTestCaseDatas()
    {
        yield return (["cba", "daf", "ghi"], 1);
        yield return (["a", "b"], 0);
        yield return (["zyx", "wvu", "tsr"], 3);
        yield return (["x", "q"], 1);
    }
}
