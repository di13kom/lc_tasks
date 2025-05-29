using LeetCode.Problems._3306;
namespace ProblemsUnitTests._3306;


public class Problem3306UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase("", 1, 0)]
    [TestCase("aqsweiio", 1, 0)]
    [TestCase("aeioqq", 1, 0)]
    [TestCase("aeiou", 0, 1)]
    [TestCase("ieaouqqieaouqq", 1, 3)]
    [TestCase("ieaouqqqieaouqq", 2, 2)]
    [TestCase("qwieaouqqqqieaouqqauieouuuuww", 2, 5)]
    [TestCase("aiqwieaouqqeioqqieaouqqauieouuuuww", 2, 5)]
    [TestCase("auieoquiaeowxiouuuaewsa", 1, 4)]
    [TestCase("iqeaouqi", 2, 0)]
    public void StringShouldReturnExactPassedCount(string inputStr, int kValue, int expectedValue)
    {
        Assert.That(new Solution().CountOfSubstrings(inputStr, kValue), Is.EqualTo(expectedValue));
    }
}
