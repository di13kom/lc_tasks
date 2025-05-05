using NUnit.Framework;
using LeetCode.Problems.PrefixSum._303;

namespace ProblemsUnitTests._263;

public class Problem263UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(new[] { -2, 0, 3, -5, 2, -1 })]
    public void Test1(int[] nums)
    {
        var array = new NumArray(nums);
        var ranges = new List<int[]> { new[] { 0, 2 }, new[] { 2, 5 }, new[] { 0, 5 } };
        var expected = new List<int> { 1, -1, -3 };
        for (int i = 0; i < ranges.Count; i++)
        {
            Assert.That(array.SumRange(ranges[i][0], ranges[i][1]), Is.EqualTo(expected[i]));
        }
    }

    [TestCase(new[] { -2, 0, 3, -5, 2, -1 })]
    public void Test2(int[] nums)
    {
        var array = new NumArray1(nums);
        var ranges = new List<int[]> { new[] { 0, 2 }, new[] { 2, 5 }, new[] { 0, 5 } };
        var expected = new List<int> { 1, -1, -3 };
        for (int i = 0; i < ranges.Count; i++)
        {
            Assert.That(array.SumRange(ranges[i][0], ranges[i][1]), Is.EqualTo(expected[i]));
        }
    }
}