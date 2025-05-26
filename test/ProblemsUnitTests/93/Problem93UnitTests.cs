using LeetCode.Problems._93;

namespace ProblemsUnitTests._93;

public class Problem93UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase("25525511135", new string[] { "255.255.11.135", "255.255.111.35" })]
    [TestCase("012201", new string[] { "0.1.2.201", "0.12.20.1", "0.122.0.1", "0.1.220.1" })]
    [TestCase("0011255245", new string[] { })]
    [TestCase("111111111111", new string[] { "111.111.111.111" })]
    [TestCase("11111111111", new string[] { "11.111.111.111", "111.11.111.111", "111.111.11.111", "111.111.111.11" })]
    [TestCase("0000", new string[] { "0.0.0.0" })]
    [TestCase("101023", new string[] { "1.0.10.23", "1.0.102.3", "10.1.0.23", "10.10.2.3", "101.0.2.3" })]
    public void Test(string input, string[] expected)
    {
        Assert.That(new Solution().RestoreIpAddresses(input), Is.EquivalentTo(expected));
    }
}
