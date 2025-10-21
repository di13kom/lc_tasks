using LeetCode.Problems.Tree;
using LeetCode.Problems.Tree._2415;

namespace ProblemsUnitTests.Tree._2415;

public class Problem2415UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int?[] input, IEnumerable<int?> expected) td)
    {
        var root = TreeNodeFactory.CreateBinaryTreeNodeFromArray(td.input);
        Assert.That(TreeNodeFactory.CreateEnumerableFromBinaryTreeNode(new Solution().ReverseOddLevels(root)), Is.EqualTo(td.expected));
    }
    private static IEnumerable<(int?[], IEnumerable<int?>)> GetTestCaseDatas()
    {
        yield return ([2, 3, 5, 8, 13, 21, 34], [2, 5, 3, 8, 13, 21, 34]);
        yield return ([7, 13, 11], [7, 11, 13]);
        yield return ([0, 1, 2, 0, 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2], [0, 2, 1, 0, 0, 0, 0, 2, 2, 2, 2, 1, 1, 1, 1]);
        yield return ([54583, 24543, 8549, 8245, 33780, 17236, 54549], [54583, 8549, 24543, 8245, 33780, 17236, 54549]);
        yield return ([7565, 76756, 28443, 35138, 21291, 12853, 21020, 73552, 35298, 52318, 77864, 93774, 25534, 65860, 78606],
                        [7565, 28443, 76756, 35138, 21291, 12853, 21020, 78606, 65860, 25534, 93774, 77864, 52318, 35298, 73552]);
    }
}