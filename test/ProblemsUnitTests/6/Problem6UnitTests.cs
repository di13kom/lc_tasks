using LeetCode.Problems._6;

namespace ProblemsUnitTests._6;

public class Problem6UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((string input, int numRows, string expected) td)
    {
        Assert.That(new Solution().Convert(td.input, td.numRows), Is.EquivalentTo(td.expected));
    }

    private static IEnumerable<(string, int, string)> GetTestCaseDatas()
    {
        yield return ("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR");
        yield return ("PAYPALISHIRING", 4, "PINALSIGYAHRPI");
        yield return ("PAYPALISHIRING", 5, "PHASIYIRPLIGAN");
        yield return ("PAYPALISHIRING", 6, "PRAIIYHNPSGAIL");
        yield return ("A", 1, "A");
        yield return ("A", 2, "A");
    }
}