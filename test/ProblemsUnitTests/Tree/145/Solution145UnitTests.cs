using LeetCode.Problems.Tree;
using LeetCode.Problems.Tree._145;

namespace ProblemsUnitTests._145;

public class Solution145UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var root = new TreeNode(int.MinValue, null, new(int.MaxValue));
        Assert.That(new Solution().PostorderTraversal(root), Is.EqualTo(new List<int>{int.MaxValue, int.MinValue}));
    }

    [Test]
    public void Test2()
    {
        var root = new TreeNode(1, null, new(2, new(3)));
        Assert.That(new Solution().PostorderTraversal(root), Is.EqualTo(new List<int>{3, 2, 1}));
    }

    [Test]
    public void Test3()
    {
        TreeNode root = null;
        Assert.That(new Solution().PostorderTraversal(root), Is.EqualTo(new List<int>()));
    }

    [Test]
    public void Test4()
    {
        var root = new TreeNode(1);
        Assert.That(new Solution().PostorderTraversal(root), Is.EqualTo(new List<int>{1}));
    }

    [Test]
    public void Test5()
    {
        //[1,2,3,4,5,null,8,null,null,6,7,9]
        var root = new TreeNode(1,
                                new(2, new(4), new(5,new(6),new(7))),
                                new(3, null,new(8,new(9))));
        Assert.That(new Solution().PostorderTraversal(root), Is.EqualTo(new List<int>{4,6,7,5,2,9,8,3,1}));
    }
}
