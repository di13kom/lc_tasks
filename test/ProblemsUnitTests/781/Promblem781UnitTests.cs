using NUnit.Framework;
using LeetCode.Problems._781;

namespace ProblemsUnitTests._781;

public class Promblem781UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(new[] { 1, 1, 2 }, 5)]
    [TestCase(new[] { 10, 10, 10 }, 11)]
    [TestCase(new[] { 0, 0, 1, 1, 1 }, 6)]
    public void Test1(int[] input, int expected)
    {
        Assert.That(new Solution().NumRabbits(input), Is.EqualTo(expected));
    }
}
