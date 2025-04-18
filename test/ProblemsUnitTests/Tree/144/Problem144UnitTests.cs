using NUnit.Framework;
using LeetCode.Problems.Tree;
using LeetCode.Problems.Tree._144;

namespace ProblemsUnitTests.Tree._144;

public class Problem144UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var root = new TreeNode(int.MinValue, null, new(int.MaxValue));
        Assert.That(new Solution().PreorderTraversal(root), Is.EqualTo(new List<int>{int.MinValue, int.MaxValue}));
    }

    [Test]
    public void Test2()
    {
        var root = new TreeNode(1, null, new(2, new(3)));
        Assert.That(new Solution().PreorderTraversal(root), Is.EqualTo(new List<int>{1, 2, 3}));
    }

    [Test]
    public void Test3()
    {
        TreeNode root = null;
        Assert.That(new Solution().PreorderTraversal(root), Is.EqualTo(new List<int>()));
    }

    [Test]
    public void Test4()
    {
        var root = new TreeNode(1);
        Assert.That(new Solution().PreorderTraversal(root), Is.EqualTo(new List<int>{1}));
    }
}
