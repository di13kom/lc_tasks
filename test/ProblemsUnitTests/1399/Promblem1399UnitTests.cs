using NUnit.Framework;
using LeetCode.Problems._1399;

namespace ProblemsUnitTests._1399;

public class Promblem1399UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(9999, 1)]
    [TestCase(13, 4)]
    [TestCase(2, 2)]
    public void Test1(int input, int expected)
    {
        Assert.That(new Solution().CountLargestGroup(input), Is.EqualTo(expected));
    }
}
