using LeetCode.Problems._2894;

namespace ProblemsUnitTests._2894;

public class Problem2894UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(10, 3, 19)]
    [TestCase(5, 6, 15)]
    [TestCase(5, 1, -15)]
    public void Test1(int n, int m, int expected)
    {
        Assert.That(new Solution().DifferenceOfSums(n, m), Is.EqualTo(expected));
    }
}
