using LeetCode.Problems._43;

namespace ProblemsUnitTests._43;

public class Problem43UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((string input0, string input1, string expected) td)
    {
        Assert.That(new Solution().Multiply(td.input0, td.input1), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(string, string, string)> GetTestCaseDatas()
    {
        yield return ("0", "0", "0");
        yield return ("2", "3", "6");
        yield return ("12", "35", "420");
        yield return ("123", "456", "56088");
        yield return ("1234", "456", "562704");
        yield return ("456", "1234", "562704");
        yield return ("99", "99", "9801");
        yield return ("111111", "1", "111111");
        yield return ("111111", "5", "555555");
    }
}
