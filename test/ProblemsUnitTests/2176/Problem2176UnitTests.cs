using LeetCode.Problems._2176;

namespace ProblemsUnitTests._2176;

public class Problem2176UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(new int[] { 3, 1, 2, 2, 2, 1, 3 }, 2, 4)]
    [TestCase(new int[] { 1, 2, 3, 4 }, 1, 0)]
    public void Test1(int[] input, int k, int expected)
    {
        Assert.That(new Solution().CountPairs(input, k), Is.EqualTo(expected));
    }
}
