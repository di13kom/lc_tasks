using LeetCode.Problems.Tree;
using LeetCode.Problems.Tree._865;

namespace ProblemsUnitTests.Tree._865;

public class Problem865UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int?[] input, IEnumerable<int?> expected) td)
    {
        var root = TreeNodeFactory.CreateBinaryTreeNodeFromArray(td.input);
        Assert.That(TreeNodeFactory.CreateEnumerableFromBinaryTreeNode(new Solution().SubtreeWithAllDeepest(root)), Is.EqualTo(td.expected));
    }
    private static IEnumerable<(int?[], IEnumerable<int?>)> GetTestCaseDatas()
    {
        yield return ([3, 5, 1, 6, 2, 0, 8, null, null, 7, 4], [2, 7, 4]);
        yield return ([1], [1]);
        yield return ([0, 1, 3, null, 2], [2]);
        yield return ([0, 1, 2, 3, null, null, 4], [0, 1, 2, 3, null, null, 4]);
        yield return ([0, 1, 2, 3, null, 4, 5], [0, 1, 2, 3, null, 4, 5]);
        yield return ([0, 1, 2, 6, 3, 5, 13, 12, 7, 8, 4, null, 15, 19, null, 30, 25, 10, 11, 20,
                            null, 22, 9, 26, 17, null, 23, null, null, 32, null, 21, null, 14, 31,
                            39, 49, null, 35, 16, 24, null, null, null, 41, null, 45, null, 33, 28,
                            34, null, null, null, null, null, null, null, null, null, 37, 29, 18, 42,
                            27, null, null, null, null, null, null, 43, null, null, 40, 46, 44, null,
                            null, null, 36, null, null, null, null, null, null, null, null, 47, 48, null, null, null, 38],
                        [4, 22, 9, null, 35, 16, 24, null, 37, 29, 18, 42, 27, 46, 44, null, null, null,
                            36, null, null, null, null, 47, 48, null, null, null, 38]);
    }
}