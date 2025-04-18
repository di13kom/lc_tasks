using NUnit.Framework;
using LeetCode.Problems.Tree;
using LeetCode.Problems.Tree._113;
using System.Collections;

namespace ProblemsUnitTests._113;

public class Problem113UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var root = new TreeNode(1);
        Assert.That(new Solution().PathSum(root, 1), Is.EqualTo(new List<List<int>> { new() { 1 } }));
    }

    [Test]
    public void Test2()
    {
        var root = new TreeNode(1, new(2), new(3));
        Assert.That(new Solution().PathSum(root, 5), Is.EqualTo(new List<List<int>> { }));
    }

    [Test]
    public void Test3()
    {
        var root = new TreeNode(5, new(3), new TreeNode(2));
        Assert.That(new Solution().PathSum(root, 7), Is.EqualTo(new List<List<int>> { new() { 5, 2 } }));
    }
    [Test]
    public void Test4()
    {
        var root = new TreeNode(5,
         new TreeNode(2, new TreeNode(2, new(4, null, new(1, new(2)))), null),
         new TreeNode(2, null, new TreeNode(2, null, new(1, null, new(4, new(2))))));
        Assert.That(new Solution().PathSum(root, 16), Is.EqualTo(new List<List<int>> { new() { 5, 2, 2, 4, 1, 2 }, new() { 5, 2, 2, 1, 4, 2 } }));
    }
    [Test]
    public void Test5()
    {
        var root = new TreeNode(5,
         new TreeNode(4, new(11, new(7), new(2))),
         new TreeNode(8, new(13), new(4, new(5), new(1))));
        Assert.That(new Solution().PathSum(root, 22), Is.EqualTo(new List<List<int>> { new() { 5, 4, 11, 2 }, new() { 5, 8, 4, 5 } }));
    }
    [Test]
    public void Test6()
    {
        var root = new TreeNode(1);
        Assert.That(new Solution().PathSum(root, 2), Is.EqualTo(new List<List<int>> { }));
    }
    [Test]
    public void Test7()
    {
        TreeNode root = null;
        Assert.That(new Solution().PathSum(root, 2), Is.EqualTo(new List<List<int>> { }));
    }
    [Test]
    public void Test8()
    {
        //[-2,null,-3]
        var root = new TreeNode(-2, null, new(-3));
        Assert.That(new Solution().PathSum(root, -5), Is.EqualTo(new List<List<int>> { new (){-2, -3} }));
    }
}
