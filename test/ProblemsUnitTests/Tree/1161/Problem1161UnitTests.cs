using LeetCode.Problems.Tree;
using LeetCode.Problems.Tree._1161;

namespace ProblemsUnitTests.Tree._1161;

public class Problem1161UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((TreeNode root, int expected) td)
    {
        Assert.That(new Solution().MaxLevelSum(td.root), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(TreeNode, int)> GetTestCaseDatas()
    {
        yield return (new TreeNode(1,
                                new(7, new(7), new(-8)),
                                new(0)), 2);
        yield return (new TreeNode(1), 1);
        yield return (new TreeNode(989,
                                 null,
                                 new(10250,
                                            new(98693),
                                            new(-89388, null, new(-32127)))), 2);
    }
}