using NUnit.Framework;
using LeetCode.Problems.Tree._111;

namespace ProblemsUnitTests.Tree._111;

public class Problem111UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var root = new TreeNode(1, new TreeNode(2, null, null));
        //Assert.That(new Solution().MinDepth(root), Is.EqualTo(2));
        Assert.That(new Solution2().MinDepth(root), Is.EqualTo(2));
    }

    [Test]
    public void Test2()
    {
        var root = new TreeNode(5,
         new TreeNode(2, new TreeNode(2, new(4, null, new(1, new(2)))), null),
         new TreeNode(2, null, new TreeNode(2, null, new(1, null, new(4, new(2))))));
        //Assert.That(new Solution().MinDepth(root), Is.EqualTo(2));
        Assert.That(new Solution2().MinDepth(root), Is.EqualTo(6));
    }

    [Test]
    public void Test3()
    {
        var root = new TreeNode(5, null,
         new TreeNode(2, null, new TreeNode(2, null, new(1, null, new(4, new(2))))));
        //Assert.That(new Solution().MinDepth(root), Is.EqualTo(6));
        Assert.That(new Solution2().MinDepth(root), Is.EqualTo(6));
    }
}
