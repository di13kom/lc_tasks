using LeetCode.Problems._119;

namespace ProblemsUnitTests._119;

public class Problem119UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(0, new[] { 1 })]
    [TestCase(1, new[] { 1, 1 })]
    [TestCase(3, new[] { 1, 3, 3, 1 })]
    [TestCase(4, new[] { 1, 4, 6, 4, 1 })]
    public void Test1(int input, int[] expected)
    {
        Assert.That(new Solution().GetRow(input), Is.EqualTo(expected));
    }
}
