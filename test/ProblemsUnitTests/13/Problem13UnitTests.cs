using LeetCode.Problems._13;
namespace ProblemsUnitTests._13;

public class Problem13UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase("III", 3)]
    [TestCase("LVIII", 58)]
    [TestCase("MCMXCIV", 1994)]
    public void Test1(string input, int expected)
    {
        Assert.That(new Solution().RomanToInt(input), Is.EqualTo(expected));
    }
}
