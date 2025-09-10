using LeetCode.Problems._3541;

namespace ProblemsUnitTests._3541;

public class Problem3541UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((string inputStr, int expected) td)
    {
        Assert.That(new Solution().MaxFreqSum(td.inputStr), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(string, int)> GetTestCaseDatas()
    {
        yield return ("successes", 6);
        yield return ("aeiaeia", 3);
    }
}