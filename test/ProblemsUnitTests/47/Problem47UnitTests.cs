using LeetCode.Problems._47;

namespace ProblemsUnitTests._47;

public class Problem47UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, IList<IList<int>> expected) td)
    {
        Assert.That(new Solution().PermuteUnique(td.input), Is.EquivalentTo(td.expected));
    }

    private static IEnumerable<(int[], IList<IList<int>>)> GetTestCaseDatas()
    {
        yield return ([1, 1, 2], [[1, 1, 2], [1, 2, 1], [2, 1, 1]]);
        yield return ([1, 2, 3], [[1, 2, 3], [1, 3, 2], [2, 1, 3], [2, 3, 1], [3, 1, 2], [3, 2, 1]]);
        yield return ([1, 2, 2, 4], [[1, 2, 2, 4], [1, 2, 4, 2], [1, 4, 2, 2],
                                        [4, 2, 2, 1],[4, 1, 2, 2],[4, 2, 1, 2],
                                        [2, 1, 2, 4],[2, 2, 1, 4],[2, 2, 4, 1],[2, 1, 4, 2],[2,4,2,1],[2,4,1,2]]);
        yield return ([1, 1, 1, 1, 1, 1, 1, 1], [[1, 1, 1, 1, 1, 1, 1, 1]]);
        yield return ([0, 1, 0, 0, 9], [[0, 0, 0, 1, 9], [0, 0, 0, 9, 1], [0, 0, 1, 0, 9], [0, 0, 1, 9, 0], [0, 0, 9, 0, 1],
                                        [0, 0, 9, 1, 0], [0, 1, 0, 0, 9], [0, 1, 0, 9, 0], [0, 1, 9, 0, 0], [0, 9, 0, 0, 1],
                                        [0, 9, 0, 1, 0], [0, 9, 1, 0, 0], [1, 0, 0, 0, 9], [1, 0, 0, 9, 0], [1, 0, 9, 0, 0],
                                        [1, 9, 0, 0, 0], [9, 0, 0, 0, 1], [9, 0, 0, 1, 0], [9, 0, 1, 0, 0], [9, 1, 0, 0, 0]]);
    }
}
