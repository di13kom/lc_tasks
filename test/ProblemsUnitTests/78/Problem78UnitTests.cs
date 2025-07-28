using LeetCode.Problems._78;

namespace ProblemsUnitTests._78;

public class Problem78UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, IList<IList<int>> expected) td)
    {
        Assert.That(new Solution().Subsets(td.input), Is.EquivalentTo(td.expected));
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Solution1Test((int[] input, IList<IList<int>> expected) td)
    {
        Assert.That(new Solution1().Subsets(td.input), Is.EquivalentTo(td.expected));
    }

    private static IEnumerable<(int[], IList<IList<int>>)> GetTestCaseDatas()
    {
        yield return ([1, 2, 3], [[], [1], [2], [1, 2], [3], [1, 3], [2, 3], [1, 2, 3]]);
        yield return ([0], [[], [0]]);
        yield return ([0, 1, 2, 3], [[], [0], [1], [0, 1], [2], [0, 2], [1, 2], [0, 1, 2],
                        [3], [0, 3], [1, 3], [0, 1, 3], [2, 3], [0, 2, 3], [1, 2, 3], [0, 1, 2, 3]]);
    }
}