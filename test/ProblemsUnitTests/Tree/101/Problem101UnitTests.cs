using LeetCode.Problems.Tree;
using LeetCode.Problems.Tree._101;

namespace ProblemsUnitTests._101;

public class Problem101UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int?[] input, bool expected) td)
    {
        var root = TreeNodeFactory.CreateBinaryTreeNodeFromArray(td.input);
        Assert.That(new Solution().IsSymmetric(root), Is.EqualTo(td.expected));
    }
    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Solution0Test((int?[] input, bool expected) td)
    {
        var root = TreeNodeFactory.CreateBinaryTreeNodeFromArray(td.input);
        Assert.That(new Solution0().IsSymmetric(root), Is.EqualTo(td.expected));
    }
    private static IEnumerable<(int?[], bool)> GetTestCaseDatas()
    {
        yield return ([1, null, 3], false);
        yield return ([1, 2, 3], false);
        yield return ([1, 2, 2, 3, 4, 4, 3], true);
        yield return ([1, 2, 2, null, 3, null, 3], false);
        yield return ([5, 2, 2, 4, null, null, 1, null, 1, null, 4, 2, null, 2, null], false);
    }
}
