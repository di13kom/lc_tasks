using LeetCode.Problems.Tree;
using LeetCode.Problems.Tree._501;

namespace ProblemsUnitTests._501;

public class Problem501UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var root = new TreeNode(1, new(3));
        int[] array = [1, 3];
        Assert.That(array, Is.EquivalentTo(new Solution().FindMode(root)));
    }
    [Test]
    public void Test2()
    {
        var root = new TreeNode(1,
                                new(2, new(3, new(3, new(4), new(4)), new(3))),
                                new(2, new(5)));
        int[] array = [3];
        Assert.That(array, Is.EquivalentTo(new Solution().FindMode(root)));
    }

    [Test]
    public void Test3()
    {
        var root = new TreeNode(1,
                                null,
                                new(2, new(2)));
        int[] array = [2];
        Assert.That(array, Is.EquivalentTo(new Solution().FindMode(root)));
    }

    [Test]
    public void Test4()
    {
        var root = new TreeNode(1);
        int[] array = [1];
        Assert.That(array, Is.EquivalentTo(new Solution().FindMode(root)));
    }

    [Test]
    public void Test5()
    {
        TreeNode root = null;
        int[] array = [];
        Assert.That(array, Is.EquivalentTo(new Solution().FindMode(root)));
    }
}
