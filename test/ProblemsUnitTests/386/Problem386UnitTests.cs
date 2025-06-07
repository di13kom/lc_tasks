using NUnit.Framework;
using LeetCode.Problems._386;

namespace ProblemsUnitTests._386;

public class Problem386UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(2, new int[] { 1, 2 })]
    [TestCase(13, new int[] { 1, 10, 11, 12, 13, 2, 3, 4, 5, 6, 7, 8, 9 })]
    [TestCase(20, new int[] { 1, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 2, 20, 3, 4, 5, 6, 7, 8, 9 })]
    [TestCase(23, new int[] { 1, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 2, 20, 21, 22, 23, 3, 4, 5, 6, 7, 8, 9 })]
    public void Test1(int input, int[] expected)
    {
        Assert.That(new Solution().LexicalOrder(input), Is.EqualTo(expected));
    }
}
