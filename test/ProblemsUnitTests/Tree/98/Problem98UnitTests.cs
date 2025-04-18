using NUnit.Framework;
using LeetCode.Problems.Tree._98;

namespace ProblemsUnitTests.Tree._98;

public class Problem98UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var root = new TreeNode(5, null,
         new TreeNode(2, null, new TreeNode(2, null, new(1, null, new(4, new(2))))));
        Assert.That(new Solution().IsValidBST(root), Is.EqualTo(false));
        Assert.That(new Solution2().IsValidBST(root), Is.EqualTo(false));
    }

    [Test]
    public void Test2()
    {
        var root = new TreeNode(2, new(1), new(3));
        Assert.That(new Solution().IsValidBST(root), Is.EqualTo(true));
        Assert.That(new Solution2().IsValidBST(root), Is.EqualTo(true));
    }

    [Test]
    public void Test3()
    {
        var root = new TreeNode(5, new(1), new(4, new(3), new (6)));
        Assert.That(new Solution().IsValidBST(root), Is.EqualTo(false));
        Assert.That(new Solution2().IsValidBST(root), Is.EqualTo(false));
    }

    [Test]
    public void Test4()
    {
        var root = new TreeNode(2, new(2), new(2));
        Assert.That(new Solution().IsValidBST(root), Is.EqualTo(false));
        Assert.That(new Solution2().IsValidBST(root), Is.EqualTo(false));
    }

    [Test]
    public void Test5()
    {
        var root = new TreeNode(2, new(-1));
        Assert.That(new Solution().IsValidBST(root), Is.EqualTo(true));
        Assert.That(new Solution2().IsValidBST(root), Is.EqualTo(true));
    }

    [Test]
    public void Test6()
    {
        var root = new TreeNode(5, new(4), new(6, new(3), new (7)));
        //Assert.That(new Solution().IsValidBST(root), Is.EqualTo(false));
        Assert.That(new Solution2().IsValidBST(root), Is.EqualTo(false));
    }

    [Test]
    public void Test7()
    {
        var root = new TreeNode(int.MinValue);
        Assert.That(new Solution().IsValidBST(root), Is.EqualTo(true));
        Assert.That(new Solution2().IsValidBST(root), Is.EqualTo(true));
    }

    [Test]
    public void Test8()
    {
        var root = new TreeNode(int.MinValue, null, new(int.MaxValue));
        Assert.That(new Solution().IsValidBST(root), Is.EqualTo(true));
        Assert.That(new Solution2().IsValidBST(root), Is.EqualTo(true));
    }
}
