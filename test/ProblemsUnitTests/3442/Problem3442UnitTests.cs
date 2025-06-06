using NUnit.Framework;
using LeetCode.Problems._3442;

namespace ProblemsUnitTests._3442;

public class Problem3442UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Test1((string input, int expected) td)
    {
        Assert.That(new Solution().MaxDifference(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(string, int)> GetTestCaseDatas()
    {
        yield return ("aaaaabbc", 3);
        yield return ("abcabcab", 1);
        yield return ("tzt", -1);
        yield return ("mmsmsym", -1);
        yield return ("aaaaaaaaabbbbbcce", 7);
        yield return ("aabbccddeeffgghhiijjkklmmnnx", -1);
    }
}
