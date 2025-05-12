using LeetCode.Problems._1920;
namespace ProblemsUnitTests._1920;

public class Promblem1920UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(new int[] { 0, 2, 1, 5, 3, 4 }, new int[] { 0, 1, 2, 4, 5, 3 })]
    [TestCase(new int[] { 5, 0, 1, 2, 3, 4 }, new int[] { 4, 5, 0, 1, 2, 3 })]
    public void Test(int[] input, int[] expected)
    {
        Assert.That(new Solution().BuildArray(input), Is.EqualTo(expected));
    }
}
