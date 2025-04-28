using NUnit.Framework;
using LeetCode.Problems._1863;

namespace ProblemsUnitTests._1863;

public class Promblem1863UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(new int[] { 1, 3 }, 6)]
    [TestCase(new int[] { 5, 1, 6 }, 28)]
    [TestCase(new int[] { 1, 2, 3 }, 12)]
    [TestCase(new int[] { 1, 2, 3, 4 }, 56)]
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 112)]
    [TestCase(new int[] { 3, 4, 5, 6, 7, 8 }, 480)]
    public void Test1(int[] input, int expected)
    {
        Assert.That(new Solution().SubsetXORSum(input), Is.EqualTo(expected));
    }
}
