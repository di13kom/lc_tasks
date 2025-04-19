using NUnit.Framework;
using LeetCode.Problems._3;

namespace ProblemsUnitTests._3;

public class Problem3UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase("abcabcbb", 3)]
    [TestCase("bbbbb", 1)]
    [TestCase("pwwkew", 3)]
    [TestCase("pw wkew2", 4)]
    [TestCase("pwwwkew2", 4)]
    [TestCase("", 0)]
    public void Test1(string input, int expected)
    {
        Assert.That(new Solution().LengthOfLongestSubstring(input), Is.EqualTo(expected));
    }
}
