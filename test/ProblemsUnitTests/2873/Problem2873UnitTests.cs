using NUnit.Framework;
using LeetCode.Problems._2873;

namespace ProblemsUnitTests._2873;

public class Problem2873UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(new int[] { 12, 6, 1, 2, 7 }, 77)]
    [TestCase(new int[] { 1, 10, 3, 4, 19 }, 133)]
    [TestCase(new int[] { 1, 2, 3 }, 0)]
    [TestCase(new int[] { 1000000, 1, 1000000 }, 999999000000)]
    [TestCase(new int[] { 18, 15, 8, 13, 10, 9, 17, 10, 2, 16, 17 }, 272)]
    [TestCase(new int[] { 8, 6, 3, 13, 2, 12, 19, 5, 19, 6, 10, 11, 9 }, 266)]
    [TestCase(new int[] { 6, 14, 20, 19, 19, 10, 3, 15, 12, 13, 8, 1, 2, 15, 3 }, 285)]
    public void Test3(int[] input, long expected)
    {
        Assert.That(new Solution().MaximumTripletValue(input), Is.EqualTo(expected));
    }
}
