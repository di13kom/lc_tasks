using NUnit.Framework;
using LeetCode.Problems.Tree._104;

namespace ProblemsUnitTests._104;

public class Problem104UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var right = new TreeNode(1, null, new TreeNode(3, null, null));
        Assert.That(new Solution().MaxDepth(right), Is.EqualTo(2));
    }

    [Test]
    public void Test2()
    {
        var root = new TreeNode(1, new TreeNode(2, null, null), new TreeNode(3, null, null));
        Assert.That(new Solution().MaxDepth(root), Is.EqualTo(2));
    }

    [Test]
    public void Test3()
    {
        var root = new TreeNode(1, new TreeNode(2, null, null), new TreeNode(3, null, new TreeNode(3,null,null)));
        Assert.That(new Solution().MaxDepth(root), Is.EqualTo(3));
    }
}
