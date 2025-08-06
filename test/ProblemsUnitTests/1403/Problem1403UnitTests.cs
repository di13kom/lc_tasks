using LeetCode.Problems._1403;

namespace ProblemsUnitTests._1403;

public class Problem1403UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, IList<int> expected) td)
    {
        Assert.That(new Solution().MinSubsequence(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], IList<int>)> GetTestCaseDatas()
    {
        yield return ([4, 3, 10, 9, 8], [10, 9]);
        yield return ([4, 4, 7, 6, 7], [7, 7, 6]);
        yield return ([4], [4]);
        yield return ([1, 4], [4]);
        yield return ([1, 1], [1, 1]);
    }
}