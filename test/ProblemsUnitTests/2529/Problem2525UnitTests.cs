using NUnit.Framework;
using LeetCode.Problems._2529;

namespace ProblemsUnitTests._2529;

public class Problem2525UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase(new[] { 0 }, 0)]
    [TestCase(new[] { 0, 0 }, 0)]
    [TestCase(new[] { 0, 0, 0, 0, 0 }, 0)]
    [TestCase(new[] { -1 }, 1)]
    [TestCase(new[] { 1 }, 1)]
    [TestCase(new[] { 1, 1 }, 2)]
    [TestCase(new[] { 1, 1, 1, 1, 1 }, 5)]
    [TestCase(new[] { 0, 0, 1, 1, 1 }, 3)]
    [TestCase(new[] { 0, 0, 0, 1, 1 }, 2)]
    [TestCase(new[] { -1, -1, -1, 0, 0 }, 3)]
    [TestCase(new[] { -2, -1, 0, 0, 1, 2 }, 2)]
    [TestCase(new[] { -2, -1, 0, 0, 0, 1, 2 }, 2)]
    [TestCase(new[] { -3, -3, -2, -1, 0, 1, 2 }, 4)]
    [TestCase(new[] { -3, -2, -1, 0, 1, 2 }, 3)]
    [TestCase(new[] { -3, -2, -1, 0, 1, 2, 3, 4, 4, 5, 6 }, 7)]
    public void Test1(int[] array, int expected)
    {
        Assert.That(new Solution().MaximumCount(array), Is.EqualTo(expected));
    }

    [Test]
    [TestCase(new[] { 0 }, 0)]
    [TestCase(new[] { 0, 0 }, 0)]
    [TestCase(new[] { 0, 0, 0, 0, 0 }, 0)]
    [TestCase(new[] { -1 }, 1)]
    [TestCase(new[] { 1 }, 1)]
    [TestCase(new[] { 1, 1 }, 2)]
    [TestCase(new[] { 1, 1, 1, 1, 1 }, 5)]
    [TestCase(new[] { 0, 0, 1, 1, 1 }, 3)]
    [TestCase(new[] { 0, 0, 0, 1, 1 }, 2)]
    [TestCase(new[] { -1, -1, -1, 0, 0 }, 3)]
    [TestCase(new[] { -2, -1, 0, 0, 1, 2 }, 2)]
    [TestCase(new[] { -2, -1, 0, 0, 0, 1, 2 }, 2)]
    [TestCase(new[] { -3, -3, -2, -1, 0, 1, 2 }, 4)]
    [TestCase(new[] { -3, -2, -1, 0, 1, 2 }, 3)]
    [TestCase(new[] { -3, -2, -1, 0, 1, 2, 3, 4, 4, 5, 6 }, 7)]
    public void Test2(int[] array, int expected)
    {
        Assert.That(new Solution().MaximumCount2(array), Is.EqualTo(expected));
    }
}
