using LeetCode.Problems._97;

namespace ProblemsUnitTests._97;

[Timeout(10000)]
public class Problem97UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((string s1, string s2, string s3, bool expected) td)
    {
        Assert.That(new Solution().IsInterleave(td.s1, td.s2, td.s3), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(string, string, string, bool)> GetTestCaseDatas()
    {
        yield return ("aabcc", "dbbca", "aadbbcbcac", true);
        yield return ("aabc", "abad", "aabadabc", true);
        yield return ("aabcc", "dbbca", "aadbbbaccc", false);
        yield return ("", "", "", true);
        yield return ("a", "b", "a", false);
        yield return ("aaaaaaaaaaaaaaaaaaaaaaaaaaa",
                        "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
                        "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
                        false);
        yield return ("abababababababababababababababababababababababababababababababababababababababababababababababababbb",
                        "babababababababababababababababababababababababababababababababababababababababababababababababaaaba",
                        "abababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababababbb",
                        false);
    }
}