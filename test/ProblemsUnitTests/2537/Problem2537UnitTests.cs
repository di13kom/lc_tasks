using NUnit.Framework;
using LeetCode.Problems._2537;

namespace ProblemsUnitTests._2537;

public class Problem2537UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(new int[] { 1, 1, 1, 1, 1 }, 10, 1)]
    [TestCase(new int[] { 3, 1, 4, 3, 2, 2, 4 }, 2, 4)]
    public void Test1(int[] input, int k, int expected)
    {
        Assert.That(new Solution().CountGood(input, k), Is.EqualTo(expected));
    }
}
