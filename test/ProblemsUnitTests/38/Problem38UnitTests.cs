using NUnit.Framework;
using LeetCode.Problems._38;

namespace ProblemsUnitTests._38;

public class Problem38UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(1, "1")]
    [TestCase(4, "1211")]
    [TestCase(6, "312211")]
    public void Test1(int input, string expected)
    {
        Assert.That(new Solution().CountAndSay(input), Is.EqualTo(expected));
    }
}
