using NUnit.Framework;
using LeetCode.Problems.Tree._100;

namespace ProblemsUnitTests._100;

public class Problem100UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var left = new TreeNode(1, new TreeNode(2, null, null), new TreeNode(3, null, null));
        var right = new TreeNode(1, new TreeNode(2, null, null), new TreeNode(3, null, null));
        Assert.That(new Solution().IsSameTree(left, right), Is.EqualTo(true));
    }

    [Test]
    public void Test2()
    {
        var left = new TreeNode(1, new TreeNode(2, null, null), null);
        var right = new TreeNode(1, null, new TreeNode(3, null, null));
        Assert.That(new Solution().IsSameTree(left, right), Is.EqualTo(false));
    }
}
