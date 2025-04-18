using NUnit.Framework;
using LeetCode.Problems.Tree;
using LeetCode.Problems.Tree._102;

namespace ProblemsUnitTests.Tree._102;

public class Problem102UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var root = new TreeNode(5,
         new TreeNode(4, new(11, new(7), new(2))),
         new TreeNode(8, new(13), new(4, new(5), new(1))));
        Assert.That(new Solution().LevelOrder(root), Is.EqualTo(new List<List<int>>
        {
            new() { 5 },
            new() { 4, 8 },
            new() { 11, 13, 4 },
            new() { 7, 2, 5, 1 }
        }));
    }

    [Test]
    public void Test2()
    {
        //[3, 9, 20, null, null, 15, 7]
        var root = new TreeNode(3,
                                new(9),
                                new(20, new(15), new(7)));

        Assert.That(new Solution().LevelOrder(root), Is.EqualTo(new List<List<int>>
        {
            new (){3},
            new (){9,20},
            new (){15,7}
        }));
    }

    [Test]
    public void Test3()
    {
        var root = new TreeNode(1);

        Assert.That(new Solution().LevelOrder(root), Is.EqualTo(new List<List<int>> { new() { 1 }, }));
    }

    [Test]
    public void Test4()
    {
        TreeNode root = null;

        Assert.That(new Solution().LevelOrder(root), Is.EqualTo(new List<List<int>> { }));
    }
}
