using NUnit.Framework;
using LeetCode.Problems.PrefixSum._238;

namespace ProblemsUnitTests._238;

public class Promblem238UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(new[] { 1, 2, 3, 4 }, new[] { 24, 12, 8, 6 })]
    [TestCase(new[] { -1, 1, 0, -3, 3 }, new[] { 0, 0, 9, 0, 0 })]
    public void Test1(int[] nums, int[] expected)
    {
        Assert.That(new Solution().ProductExceptSelf(nums), Is.EqualTo(expected));
        Assert.That(new Solution2().ProductExceptSelf(nums), Is.EqualTo(expected));
    }
}
