using LeetCode.Problems._67;

namespace ProblemsUnitTests._67;

public class Problem67UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Solution1Test((string inputA, string inputB, string expected) td)
    {
        Assert.That(new Solution().AddBinary(td.inputA, td.inputB), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(string, string, string)> GetTestCaseDatas()
    {
        yield return ("11", "1", "100");
        yield return ("1010", "1011", "10101");
        yield return ("0", "1", "1");
    }
}

