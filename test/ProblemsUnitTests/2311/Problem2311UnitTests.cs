using NUnit.Framework;
using LeetCode.Problems._2311;

namespace ProblemsUnitTests._2311;

public class Problem2311UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Test1((string input, int k, int expected) td)
    {
        Assert.That(new Solution().LongestSubsequence(td.input, td.k), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(string, int, int)> GetTestCaseDatas()
    {
        yield return ("1001010", 5, 5);
        yield return ("00101001", 1, 6);
        yield return ("0", 1, 1);
        yield return ("1111111111", 1, 1);
        yield return ("0001101010", 5, 7);
        yield return ("11001101000111010111", 15, 11);
        yield return ("00101000001101011111111110110111101011010011100100", 5, 22);
        yield return ("10011000001011111001010001111000100111110011010101100010111000100000011101111100011010011000101101110010111110011100010000000111111111101110111110101110110000011111110001101010110110001000010101001000", 10, 96);
        yield return ("111100010000011101001110001111000000001011101111111110111000011111011000010101110100110110001111001001011001010011010000011111101001101000000101101001110110000111101011000101", 11713332, 96);
    }
}