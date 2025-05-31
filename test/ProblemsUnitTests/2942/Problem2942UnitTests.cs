using NUnit.Framework;
using LeetCode.Problems._2942;

namespace ProblemsUnitTests._2942;

public class Problem2942UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Test1((string[] input, char k, IList<int> expected) td)
    {
        Assert.That(new Solution().FindWordsContaining(td.input, td.k), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(string[], char, IList<int>)> GetTestCaseDatas()
    {
        yield return (["leet", "code"], 'e', [0, 1]);
        yield return (["abc", "bcd", "aaaa", "cbc"], 'a', [0, 2]);
        yield return (["abc","bcd","aaaa","cbc"], 'z', []);
    }
}
