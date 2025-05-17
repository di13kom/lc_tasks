using LeetCode.Problems._1007;

namespace ProblemsUnitTests._1007;

public class Promblem1007UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(new int[] { 1, 1, 2, 2 }, new int[] { 2, 1, 1, 1 }, 1)]
    [TestCase(new int[] { 2, 1, 2, 4, 2, 2 }, new int[] { 5, 2, 6, 2, 3, 2 }, 2)]
    [TestCase(new int[] { 3, 5, 1, 2, 3 }, new int[] { 3, 6, 3, 3, 4 }, -1)]
    [TestCase(new int[] { 1, 1, 1, 2, 2, 2 }, new int[] { 5, 5, 5, 1, 1, 1 }, 3)]
    [TestCase(new int[] { 1, 2, 1, 1, 1, 2, 2, 2 }, new int[] { 2, 1, 2, 2, 2, 2, 2, 2 }, 1)]
    public void Test(int[] tops, int[] bottoms, int expected)
    {
        Assert.That(new Solution().MinDominoRotations(tops, bottoms), Is.EqualTo(expected));
    }
}
