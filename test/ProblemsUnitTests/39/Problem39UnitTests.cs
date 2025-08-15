using LeetCode.Problems._39;

namespace ProblemsUnitTests._39;

public class Problem39UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, int target, IList<IList<int>> expected) td)
    {
        Assert.That(new Solution().CombinationSum(td.input, td.target), Is.EquivalentTo(td.expected));
    }

    private static IEnumerable<(int[], int, IList<IList<int>>)> GetTestCaseDatas()
    {
        yield return ([2, 3, 6, 7], 7, [[2, 2, 3], [7]]);
        yield return ([2, 3, 5], 8, [[2, 2, 2, 2], [2, 3, 3], [3, 5]]);
        yield return ([2], 1, []);
    }
}
