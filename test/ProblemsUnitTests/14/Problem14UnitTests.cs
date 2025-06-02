using NUnit.Framework;
using LeetCode.Problems._14;

namespace ProblemsUnitTests._14;

public class Problem14UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Test1((string[] input, string expected) td)
    {
        Assert.That(new Solution().LongestCommonPrefix(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(string[], string)> GetTestCaseDatas()
    {
        yield return (["flower","flow","flight"],"fl");
        yield return (["dog","racecar","car"],"");
    }
}
