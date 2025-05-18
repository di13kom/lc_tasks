using LeetCode.Problems._3024;


namespace ProblemsUnitTests._3024;

public class Promblem3024UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(new int[] { 3, 3, 3 }, "equilateral")]
    [TestCase(new int[] { 3, 4, 5 }, "scalene")]
    public void Test1(int[] input, string expected)
    {
        Assert.That(new Solution().TriangleType(input), Is.EqualTo(expected));
    }
}
