using LeetCode.Problems.DivideAndConquer._190;

namespace ProblemsUnitTests._190;

public class Problem190UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(4294967293u, 3221225471u)]
    [TestCase(43261596u, 964176192u)]
    [TestCase(0u, 0u)]
    public void Test1(uint input, uint expected)
    {
        Assert.That(new Solution().reverseBits(input), Is.EqualTo(expected));
    }
}
