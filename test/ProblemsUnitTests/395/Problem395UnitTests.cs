using NUnit.Framework;
using LeetCode.Problems._395;

namespace ProblemsUnitTests._395;

public class Problem395UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((string input, int k, int expected) td)
    {
        Assert.That(new Solution().LongestSubstring(td.input, td.k), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(string, int, int)> GetTestCaseDatas()
    {
        yield return ("aaabb", 3, 3);
        yield return ("ababbc", 2, 5);
        yield return ("ababacb", 3, 0);
        yield return ("bbaaacbd", 3, 3);
        yield return ("aabcabb", 3, 0);
        yield return ("aacbbbdc", 2, 3);
    }
}
