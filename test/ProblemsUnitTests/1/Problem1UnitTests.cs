using NUnit.Framework;
using LeetCode.Problems._1;

namespace ProblemsUnitTests;

public class Problem1UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase(new[] { 2, 7, 11, 15 }, 9, new[]{0,1})]
    //[TestCase(new[]{3,2,4}, 6, new[]{}]
    public void Test1(int[] array, int target, int[] expected)
    {
        Assert.That(new Solution().TwoSum(array, target), Is.EqualTo(expected));
    }
}
