using NUnit.Framework;
using LeetCode.Problems._3423;

namespace ProblemsUnitTests._3423;

public class Problem3423UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Test1((int[] input, int expected) td)
    {
        Assert.That(new Solution().MaxAdjacentDistance(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int)> GetTestCaseDatas()
    {
        yield return ([1,2,4], 3);
        yield return ([-5,-10,-5], 5);
    }
}
