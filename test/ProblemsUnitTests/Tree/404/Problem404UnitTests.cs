using LeetCode.Problems.Tree;
using LeetCode.Problems.Tree._404;

namespace ProblemsUnitTests._404;

public class Problem404UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var root = new TreeNode(1,
                                new(2, new(3, new(3, new(4), new(4)), new(3))),
                                new(2, new(5)));
        Assert.That(new Solution().SumOfLeftLeaves(root), Is.EqualTo(9));
    }

    [Test]
    public void Test2()
    {
        var root = new TreeNode(1);
        Assert.That(new Solution().SumOfLeftLeaves(root), Is.EqualTo(0));
    }
    [Test]
    public void Test3()
    {
        var root = new TreeNode(1, new(7));
        Assert.That(new Solution().SumOfLeftLeaves(root), Is.EqualTo(7));
    }
    [Test]
    public void Test4()
    {
        var root = new TreeNode(1, null, new(7));
        Assert.That(new Solution().SumOfLeftLeaves(root), Is.EqualTo(0));
    }
}
