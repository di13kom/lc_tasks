using LeetCode.Problems._2273;

namespace ProblemsUnitTests._2273;

public class Problem2273UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((string[] input, IList<string> expected) td)
    {
        Assert.That(new Solution().RemoveAnagrams(td.input), Is.EquivalentTo(td.expected));
    }

    private static IEnumerable<(string[], IList<string>)> GetTestCaseDatas()
    {
        yield return (["abba", "baba", "bbaa", "cd", "cd"], ["abba", "cd"]);
        yield return (["a", "b", "c", "d", "e"], ["a", "b", "c", "d", "e"]);
        yield return (["a", "b", "a"], ["a", "b", "a"]);
        yield return (["abbb", "aaab"], ["abbb", "aaab"]);
    }
}
