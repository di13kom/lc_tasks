using LeetCode.Problems.DivideAndConquer._1763;

namespace ProblemsUnitTests.DivideAndConquer._1763;

public class Promblem1763UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase("YazaAay", "aAa")]
    [TestCase("Bb", "Bb")]
    [TestCase("c", "")]
    public void Test1(string input, string expected)
    {
        Assert.That(new Solution().LongestNiceSubstring(input), Is.EqualTo(expected));
    }
}
