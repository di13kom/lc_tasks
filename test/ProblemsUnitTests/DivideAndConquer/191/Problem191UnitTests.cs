using NUnit.Framework;
using LeetCode.Problems.DivideAndConquer._191;

namespace ProblemsUnitTests.DivideAndConquer._191;

public class Problem191UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(11, 3)]
    [TestCase(128, 1)]
    [TestCase(2147483645, 30)]
    public void Test1(int input, int expected)
    {
        Assert.That(new Solution().HammingWeight(input), Is.EqualTo(expected));
    }
}
