using NUnit.Framework;
using LeetCode.Problems._2131;

namespace ProblemsUnitTests._2131;

public class Problem2131UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    //[Test, CancelAfter(10000)]
    //public void Test1(CancellationToken token)
    [TestCase(new string[] { "gg" }, 2)]
    [TestCase(new string[] { "lc" }, 0)]
    [TestCase(new string[] { "lc", "cl", "gg" }, 6)]
    [TestCase(new string[] { "ab", "ty", "yt", "lc", "cl", "ab" }, 8)]
    [TestCase(new string[] { "cc", "ll", "xx" }, 2)]
    [TestCase(new string[] {"dd","aa","bb","dd","aa","dd","bb","dd","aa","cc","bb","cc","dd","cc"}, 22)]
    [TestCase(new string[] {"dd","aa","bb","dd","aa","dd","bb","dd","aa","cc","bb","cc","dd","cc"}, 22)]
    [Timeout(10000)]
    public void Test1(string[] input, int expected)
    {
        Assert.That(new Solution().LongestPalindrome(input), Is.EqualTo(expected));
    }
}
