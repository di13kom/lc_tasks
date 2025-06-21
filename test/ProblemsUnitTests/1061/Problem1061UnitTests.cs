using LeetCode.Problems._1061;

namespace ProblemsUnitTests._1061;

public class Problem1061UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((string input1, string input2, string baseStr, string expected) td)
    {
        Assert.That(new Solution().SmallestEquivalentString(td.input1, td.input2, td.baseStr), Is.EqualTo(td.expected));
    }
    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Solution1Test((string input1, string input2, string baseStr, string expected) td)
    {
        Assert.That(new Solution1().SmallestEquivalentString(td.input1, td.input2, td.baseStr), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(string, string, string, string)> GetTestCaseDatas()
    {
        yield return ("parker", "morris", "parser", "makkek");
        yield return ("hello", "world", "hold", "hdld");
        yield return ("leetcode","programs","sourcecode", "aauaaaaada");
        yield return ("napytcplhv", "hqbpvxyeyy", "abcdefghijklmnopqrstuvwxyz", "abcdefgbijkembobarsbubwcbz");
        yield return ("azyxwvutsrqponmlkjihgfedcb", "zyxwvutsrqponmlkjihgfedcba", "abcdefghijklmnopqrstuvwxyz", "aaaaaaaaaaaaaaaaaaaaaaaaaa");
    }
}
