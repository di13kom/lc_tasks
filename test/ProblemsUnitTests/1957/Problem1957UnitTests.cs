using LeetCode.Problems._1957;

namespace ProblemsUnitTests._1957;

public class Problem1957UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Solution1Test((string input, string expected) td)
    {
        Assert.That(new Solution().MakeFancyString(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(string, string)> GetTestCaseDatas()
    {
        yield return ("leeetcode", "leetcode");
        yield return ("aaabaaaa", "aabaa");
        yield return ("aab", "aab");
        yield return ("aaa", "aa");
        yield return ("a", "a");
    }
}
