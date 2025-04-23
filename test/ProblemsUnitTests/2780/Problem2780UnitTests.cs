using LeetCode.Problems._2780;

namespace ProblemsUnitTests._2780;

public class Problem2780UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(new int[] { 1, 2, 2, 2 }, 2)]
    [TestCase(new int[] { 2, 1, 3, 1, 1, 1, 7, 1, 2, 1 }, 4)]
    [TestCase(new int[] { 3, 3, 3, 3, 7, 2, 2 }, -1)]
    public void Test1(int[] input, int expected)
    {
        Assert.That(new Solution().MinimumIndex(input), Is.EqualTo(expected));
    }
}
