using NUnit.Framework;

using LeetCode.Problems._2226;


namespace ProblemsUnitTests._2226;

public class Problem2226UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(new[] { 2, 5 }, 11, 0)]
    [TestCase(new[] { 5, 8, 6 }, 3, 5)]
    [TestCase(new[] { 0, 8, 6 }, 3, 4)]
    [TestCase(new[] { 6, 8, 6 }, 3, 6)]
    [TestCase(new[] { 7, 8, 6 }, 3, 6)]
    public void Test1(int[] candies, int k, int expected)
    {
        Assert.That(new Solution().MaximumCandies(candies, k), Is.EqualTo(expected));
    }
}
