using LeetCode.Problems._3005;

namespace ProblemsUnitTests._3005;

public class Problem3305UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, int expected) td)
    {
        Assert.That(new Solution().MaxFrequencyElements(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int)> GetTestCaseDatas()
    {
        yield return ([1, 2, 2, 3, 1, 4], 4);
        yield return ([1, 2, 3, 4, 5], 5);
    }
}
