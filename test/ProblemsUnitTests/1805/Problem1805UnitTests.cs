using LeetCode.Problems._1805;

namespace ProblemsUnitTests._1805;

public class Problem1805UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((string input, int expected) td)
    {
        Assert.That(new Solution().NumDifferentIntegers(td.input), Is.EqualTo(td.expected));
    }
    private static IEnumerable<(string, int)> GetTestCaseDatas()
    {
        yield return ("a123bc34d8ef34", 3);
        yield return ("leet1234code234", 2);
        yield return ("a1b01c001", 1);
        yield return ("167278959591294", 1);
        yield return ("0a0",1);
    }
}