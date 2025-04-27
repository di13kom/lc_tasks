using NUnit.Framework;
using LeetCode.Problems._2206;


namespace ProblemsUnitTests._2206;

public class Problem2206UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(new int[] { 1, 2, 3, 4 }, false)]
    [TestCase(new int[] { 3, 2, 3, 2, 2, 2 }, true)]
    [TestCase(new int[] { 3, 4, 5, 6, 7, 8 }, false)]
    public void Test1(int[] input, bool expected)
    {
        Assert.That(new Solution().DivideArray(input), Is.EqualTo(expected));
    }
}
