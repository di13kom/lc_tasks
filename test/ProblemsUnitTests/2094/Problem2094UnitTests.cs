using LeetCode.Problems._2094;

namespace ProblemsUnitTests._2094;

public class Problem2094UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(new int[] { 2, 1, 3, 0 }, new int[] { 102, 120, 130, 132, 210, 230, 302, 310, 312, 320 })]
    [TestCase(new int[] { 2, 2, 8, 8, 2 }, new int[] { 222, 228, 282, 288, 822, 828, 882 })]
    [TestCase(new int[] { 3, 7, 5 }, new int[] { })]
    [TestCase(new int[] { 1, 2, 3 }, new int[] { 132, 312 })]
    public void Test1(int[] targetArray, int[] expected)
    {
        Assert.Multiple(() =>
        {
            //Assert.That(new Solution().FindEvenNumbers(targetArray), Is.EqualTo(expected));
            Assert.That(new Solution2().FindEvenNumbers(targetArray), Is.EqualTo(expected));
        });
    }
}
