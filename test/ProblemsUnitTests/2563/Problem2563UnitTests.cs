using LeetCode.Problems._2563;

namespace ProblemsUnitTests._2563;

public class Problem2363UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(new[] { 0, 1, 7, 4, 4, 5 }, 3, 6, 6)]
    [TestCase(new[] { 1, 7, 9, 2, 5 }, 11, 11, 1)]
    [TestCase(new[] { -1, 0 }, 1, 1, 0)]
    [TestCase(new[] { 0, 0, 0, 0, 0, 0 }, 0, 0, 15)]
    [TestCase(new[] { 6, 9, 4, 2, 7, 5, 10, 3 }, 13, 13, 3)]
    [TestCase(new[] { -5, -7, -5, -7, -5 }, -12, -12, 6)]
    public void Test1(int[] input, int lower, int upper, int expected)
    {
        Assert.That(new Solution().CountFairPairs(input, lower, upper), Is.EqualTo(expected));
    }
}
