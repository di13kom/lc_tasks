using LeetCode.Problems._229;

namespace ProblemsUnitTests._229;

public class Problem229UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, IList<int> expected) td)
    {
        Assert.That(new Solution().MajorityElement(td.input), Is.EqualTo(td.expected));
    }
    private static IEnumerable<(int[], IList<int>)> GetTestCaseDatas()
    {
        yield return ([3, 2, 3], [3]);
        yield return ([1], [1]);
        yield return ([1, 2], [1, 2]);
        yield return ([1, 2, 3], []);
        yield return ([1, 2, 4, 4], [4]);
        yield return ([2, 1, 1, 3, 1, 4, 5, 6], [1]);
        yield return ([1, 1, 1, 1, 1, 1, 1, 1, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7], [6, 7]);
        yield return ([1, 2, 2, 2, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8], [6, 8]);
    }
}