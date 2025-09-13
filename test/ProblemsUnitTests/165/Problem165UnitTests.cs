using LeetCode.Problems._165;

namespace ProblemsUnitTests._165;

public class Problem165UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((string version1, string version2, int expected) td)
    {
        Assert.That(new Solution().CompareVersion(td.version1, td.version2), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(string, string, int)> GetTestCaseDatas()
    {
        yield return ("1.2", "1.10", -1);
        yield return ("1.01", "1.001", 0);
        yield return ("1.01.001001", "1.01.000101", 1);
        yield return ("1.0", "1.0.0.0", 0);
        yield return ("1", "1.1.0.1.0", -1);
    }
}