using LeetCode.Problems.Tree._94;

namespace ProblemsUnitTests._94;

public class Problem94UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var left = new TreeNode(1, new TreeNode(2, null, null), new TreeNode(3, null, null));
        Assert.That(new Solution().InorderTraversal(left), Is.EqualTo(new List<int>{2,1,3}));
    }
    [Test]
    public void Test2()
    {
        TreeNode left = null;
        Assert.That(new Solution().InorderTraversal(left), Is.EqualTo(new List<int>{}));
    }
    [Test]
    public void Test3()
    {
        var root = new TreeNode(1, null, new TreeNode(3, new TreeNode(2, null, null), null));
        Assert.That(new Solution().InorderTraversal(root), Is.EqualTo(new List<int>{1,2,3}));
    }
}
