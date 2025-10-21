using LeetCode.Problems.Tree;
using LeetCode.Problems.Tree._94;

namespace ProblemsUnitTests._94;

public class Problem94UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int?[] input, IEnumerable<int?> expected) td)
    {
        var root = TreeNodeFactory.CreateBinaryTreeNodeFromArray(td.input);
        Assert.That(new Solution().InorderTraversal(root), Is.EqualTo(td.expected));
    }
    private static IEnumerable<(int?[], IEnumerable<int?>)> GetTestCaseDatas()
    {
        yield return ([1, null, 2, 3], [1, 3, 2]);
        yield return ([1, 2, 3], [2, 1, 3]);
        yield return ([1, null, 3, 2], [1, 2, 3]);
        yield return ([], []);
        yield return ([1], [1]);
        yield return ([1, 2, 3, 4, 5, null, 8, null, null, 6, 7, 9], [4, 2, 6, 5, 7, 1, 3, 9, 8]);
    }
}
