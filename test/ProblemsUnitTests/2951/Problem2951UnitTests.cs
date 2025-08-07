using LeetCode.Problems._2951;

namespace ProblemsUnitTests._2951;

public class Problem2951UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, int[] expected) td)
    {
        Assert.That(new Solution().FindPeaks(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int[])> GetTestCaseDatas()
    {
        yield return ([2, 4, 4], []);
        yield return ([1, 4, 3, 8, 5], [1, 3]);
        yield return ([2, 3, 3, 2], []);
        yield return ([2, 1, 1], []);
        yield return ([2, 2, 2], []);
    }
}