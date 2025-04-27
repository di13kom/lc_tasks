using NUnit.Framework;
using LeetCode.Problems._2965;

namespace ProblemsUnitTests._2965;

public class Problem2965UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        int[][] input = [[1, 3], [2, 2]];
        int[] expected = [2, 4];
        Assert.That(new Solution().FindMissingAndRepeatedValues(input), Is.EqualTo(expected));
    }

    [Test]
    public void Test2()
    {
        int[][] input = [[9, 1, 7], [8, 9, 2], [3, 4, 6]];
        int[] expected = [9, 5];
        Assert.That(new Solution().FindMissingAndRepeatedValues(input), Is.EqualTo(expected));
    }
}
