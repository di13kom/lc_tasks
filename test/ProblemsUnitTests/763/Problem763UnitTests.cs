using NUnit.Framework;
using LeetCode.Problems._763;

namespace ProblemsUnitTests._763;

public class Problem763UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase("ababcbacadefegdehijhklij", new[] { 9, 7, 8 })]
    [TestCase("eccbbbbdec", new[] { 10 })]
    [TestCase("e", new[] { 1 })]
    [TestCase("exxzzzbdac", new[] { 1, 2, 3, 1, 1, 1, 1 })]
    [TestCase("qiejxqfnqceocmy", new[] { 13, 1, 1 })]
    public void Test1(string target, int[] expected)
    {
        Assert.That(new Solution().PartitionLabels(target), Is.EqualTo(expected));
    }
}
