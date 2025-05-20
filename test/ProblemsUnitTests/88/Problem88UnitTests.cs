using NUnit.Framework;
using LeetCode.Problems._88;

namespace ProblemsUnitTests._88;

public class Problem150UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase(new[] { 1 }, 1, new int[] { }, 0, new[] { 1 })]
    [TestCase(new[] { 0 }, 0, new[] { 1 }, 1, new[] { 1 })]
    [TestCase(new[] { 1, 2, 3, 0, 0, 0 }, 3, new[] { 2, 5, 6 }, 3, new[] { 1, 2, 2, 3, 5, 6 })]
    [TestCase(new[] { -3, -2, -1, 0, 1, 0, 0, 0, 0, 0, 0, 0 }, 5, new[] { 1, 2, 3, 4, 5, 6, 7 }, 7, new[] { -3, -2, -1, 0, 1, 1, 2, 3, 4, 5, 6, 7 })]
    public void Test1(int[] nums1, int m, int[] nums2, int n, int[] expected)
    {
        new Solution().Merge(nums1, m, nums2, n);
        Assert.That(nums1, Is.EquivalentTo(expected));
    }
}
