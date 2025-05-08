using LeetCode.Problems._1295;

namespace ProblemsUnitTests._1295;

public class Problem1295UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(new[] { 12, 345, 2, 6, 7896 }, 2)]
    [TestCase(new[] { 555, 901, 482, 1771 }, 1)]
    public void Test1(int[] arr, int expected)
    {
        Assert.That(new Solution().FindNumbers(arr), Is.EqualTo(expected));
    }
}
