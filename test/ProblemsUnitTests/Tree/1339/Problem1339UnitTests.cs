using LeetCode.Problems.Tree;
using LeetCode.Problems.Tree._1339;

namespace ProblemsUnitTests.Tree._1339;

public class Problem1339UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((TreeNode root, int expected) td)
    {
        Assert.That(new Solution().MaxProduct(td.root), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(TreeNode, int)> GetTestCaseDatas()
    {
        yield return (new TreeNode(1, new(1)), 1);
        yield return (new TreeNode(1,
                                new(2, new(4), new(5)),
                                new(3, new(6))), 110);
        yield return (new TreeNode(1,
                                 null,
                                 new(2,
                                        new(3),
                                        new(4, new(5), new(6)))), 90);
    }
}