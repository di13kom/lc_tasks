using LeetCode.Problems.DivideAndConquer._1763;

namespace ProblemsUnitTests.DivideAndConquer._1763;

public class Promblem1763UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((string input, string expected) td)
    {
        Assert.That(new Solution().LongestNiceSubstring(td.input), Is.EqualTo(td.expected));
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Solution1Tests((string input, string expected) td)
    {
        Assert.That(new Solution1().LongestNiceSubstring(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(string, string)> GetTestCaseDatas()
    {
        yield return ("YazaAay", "aAa");
        yield return ("Bb", "Bb");
        yield return ("BubUYyHk", "BubUYy");
        yield return ("HkhBubUYyHkh", "hBubUYyH");
        yield return ("xLeElzxgHzcWslEdgMGwEOZCXwwDMwcEhgJHLL", "LeEl");
        yield return ("c", "");
    }
}

