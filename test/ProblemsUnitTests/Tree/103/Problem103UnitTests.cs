using LeetCode.Problems.Tree;
using LeetCode.Problems.Tree._103;

namespace ProblemsUnitTests.Tree._103;

public class Problem103UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int?[] input, IList<IList<int>> expected) td)
    {
        var root = TreeNodeFactory.CreateBinaryTreeNodeFromArray(td.input);
        Assert.That(new Solution().ZigzagLevelOrder(root), Is.EqualTo(td.expected));
    }
    private static IEnumerable<(int?[], IList<IList<int>>)> GetTestCaseDatas()
    {
        yield return ([3, 9, 20, null, null, 15, 7], [[3], [20, 9], [15, 7]]);
        yield return ([1], [[1]]);
        yield return ([], []);
        yield return ([1, 2, 3, 4, null, null, 5], [[1], [3, 2], [4, 5]]);
        yield return ([1, 2, 3, 4, 5, 6, 7], [[1], [3, 2], [4, 5, 6, 7]]);
    }
}