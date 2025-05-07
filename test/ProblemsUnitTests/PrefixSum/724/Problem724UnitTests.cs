using NUnit.Framework;
using LeetCode.Problems.PrefixSum._724;

namespace ProblemsUnitTests.PrefixSum._724;

public class Problem724UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(new[] { 1, 7, 3, 6, 5, 6 }, 3)]
    [TestCase(new[] { 1, 2, 3 }, -1)]
    [TestCase(new[] { 2, 1, -1 }, 0)]
    public void Test1(int[] nums, int expected)
    {
        Assert.That(new Solution().PivotIndex(nums), Is.EqualTo(expected));
    }
}
