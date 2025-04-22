using LeetCode.Problems._12;
namespace ProblemsUnitTests._12;

public class Problem12UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(3, "III")]
    [TestCase(58, "LVIII")]
    [TestCase(1994, "MCMXCIV")]
    [TestCase(3749, "MMMDCCXLIX")]
    public void Test1(int input, string expected)
    {
        Assert.That(new Solution().IntToRoman(input), Is.EqualTo(expected));
    }
}
