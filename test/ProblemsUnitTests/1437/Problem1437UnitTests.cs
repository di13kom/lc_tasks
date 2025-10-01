using LeetCode.Problems._1437;

namespace ProblemsUnitTests._1437;

public class Problem1437UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, int k, bool expected) td)
    {
        Assert.That(new Solution().KLengthApart(td.input, td.k), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int, bool)> GetTestCaseDatas()
    {
        yield return ([1, 0, 0, 0, 1, 0, 0, 1], 2, true);
        yield return ([1, 0, 0, 1, 0, 1], 2, false);
    }
}
