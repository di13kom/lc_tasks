using LeetCode.Problems._2810;

namespace ProblemsUnitTests._2810;

public class Problem2810UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Test1((string input, string expected) td)
    {
        Assert.That(new Solution().FinalString(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(string, string)> GetTestCaseDatas()
    {
        yield return ("string", "rtsng");
        yield return ("poiinter", "ponter");
    }
}