using LeetCode.Problems.Tree;
using LeetCode.Problems.Tree._110;

namespace ProblemsUnitTests._110;

public class Problem110UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var root = new TreeNode(1, new TreeNode(2), new TreeNode(3, null, new TreeNode(3)));
        Assert.That(new Solution().IsBalanced(root), Is.EqualTo(true));
    }

    [Test]
    public void Test2()
    {
        var root = new TreeNode(3, new(9), new(20, new(15), new(7)));
        Assert.That(new Solution().IsBalanced(root), Is.EqualTo(true));
    }

    [Test]
    public void Test3()
    {
        var root = new TreeNode(1,
                                new(2, new(3, new(3, new(4), new(4)), new(3))),
                                new(2));
        Assert.That(new Solution().IsBalanced(root), Is.EqualTo(false));
    }

    [Test]
    public void Test4()
    {
        //[1,2,2,3,null,null,3,4,null,null,4]
        var root = new TreeNode(1,
                                new(2, new(3, new(4))),
                                new(2, null, new(3, null, new(4))));
        Assert.That(new Solution3().IsBalanced(root), Is.EqualTo(false));
    }

    [Test]
    public void Test5()
    {
        //[1,2,3,4,5,6,null,8]
        var root = new TreeNode(1,
                                new(2, new(4, null, new(8)), new(5)),
                                new(3, new (6)));
        Assert.That(new Solution().IsBalanced(root), Is.EqualTo(true));
    }
}
