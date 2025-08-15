using LeetCode.Problems._40;

namespace ProblemsUnitTests._40;

[Timeout(10_000)]
public class Problem40UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, int target, IList<IList<int>> expected) td)
    {
        Assert.That(new Solution().CombinationSum2(td.input, td.target), Is.EquivalentTo(td.expected));
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest1((int[] input, int target, IList<IList<int>> expected) td)
    {
        Assert.That(new Solution1().CombinationSum2(td.input, td.target), Is.EquivalentTo(td.expected));
    }

    private static IEnumerable<(int[], int, IList<IList<int>>)> GetTestCaseDatas()
    {
        yield return ([10, 1, 2, 7, 6, 1, 5], 8, [[1, 1, 6], [1, 2, 5], [1, 7], [2, 6]]);
        yield return ([2, 5, 2, 1, 2], 5, [[1, 2, 2], [5]]);
        yield return (Enumerable.Repeat(1, 100).ToArray(), 30, [Enumerable.Repeat(1, 30).ToList()]);
        yield return (Enumerable.Repeat(2, 40).ToArray(), 60, [Enumerable.Repeat(2, 30).ToList()]);
    }
}
