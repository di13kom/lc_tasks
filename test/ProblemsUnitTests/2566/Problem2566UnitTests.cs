using NUnit.Framework;
using LeetCode.Problems._2566;

namespace ProblemsUnitTests._2566;

public class Problem2566UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(90, 99)]
    [TestCase(11891, 99009)]
    public void Test1(int input, int expected)
    {
        Assert.That(new Solution().MinMaxDifference(input), Is.EqualTo(expected));
    }
}
