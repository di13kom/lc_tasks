using LeetCode.Problems._2785;

namespace ProblemsUnitTests._2785;

public class Problem2785UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((string input, string expected) td)
    {
        Assert.That(new Solution().SortVowels(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(string, string)> GetTestCaseDatas()
    {
        yield return ("lEetcOde", "lEOtcede");
        yield return ("lYmpH", "lYmpH");
        yield return ("RiQYo","RiQYo");
    }
}