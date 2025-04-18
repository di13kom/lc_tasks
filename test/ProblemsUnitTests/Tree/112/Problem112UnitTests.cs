using NUnit.Framework;
using LeetCode.Problems._112;

namespace ProblemsUnitTests._112;

public class Problem112UnitTests
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
        Assert.That(new Solution().HasPathSum(root, 16), Is.EqualTo(true));
        Assert.That(new Solution2().HasPathSum(root, 16), Is.EqualTo(true));
    }

    [Test]
    public void Test2()
    {
        var root = new TreeNode(5, new(3), new TreeNode(2));
        Assert.That(new Solution().HasPathSum(root, 7), Is.EqualTo(true));
        Assert.That(new Solution2().HasPathSum(root, 7), Is.EqualTo(true));
    }
    
    [Test]
    public void Test3()
    {
        var root = new TreeNode(1, new(2));
        Assert.That(new Solution().HasPathSum(root, 1), Is.EqualTo(false));
        Assert.That(new Solution2().HasPathSum(root, 1), Is.EqualTo(false));
    }

    [Test]
    public void Test4()
    {
        var root = new TreeNode(1);
        Assert.That(new Solution().HasPathSum(root, 1), Is.EqualTo(true));
        Assert.That(new Solution2().HasPathSum(root, 1), Is.EqualTo(true));
    }
}
