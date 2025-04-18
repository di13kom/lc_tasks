using LeetCode.Problems.Tree._101;

namespace ProblemsUnitTests._101;

public class Problem101UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var right = new TreeNode(1, null, new TreeNode(3));
        //Assert.That(new Solution().IsSymmetric(right), Is.EqualTo(false));
    }

    [Test]
    public void Test2()
    {
        var right = new TreeNode(1, new TreeNode(2), new TreeNode(3));
        Assert.That(new Solution().IsSymmetric(right), Is.EqualTo(false));
    }

    [Test]
    public void Test3()
    {
        var right = new TreeNode(1, new TreeNode(2, new TreeNode(3), new TreeNode(4)), new TreeNode(2, new TreeNode(4), new TreeNode(3)));
        Assert.That(new Solution().IsSymmetric(right), Is.EqualTo(true));
    }

    [Test]
    public void Test4()
    {
        var right = new TreeNode(1, new TreeNode(2, new TreeNode(2), null), new TreeNode(2, new TreeNode(2), null));
        Assert.That(new Solution().IsSymmetric(right), Is.EqualTo(false));
    }

    [Test]
    public void Test5()
    {
        //int?[] lst = [5, 2, 2, 4, null, null, 1, null, 1, null, 4, 2, null, 2, null];
        int?[] lst = [1, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4, 4];
        //var tree = new TreeNodeFactory().CreateBinaryTreeNodeByArray(lst);


        var right = new TreeNode(5,
         new TreeNode(2, new TreeNode(2, new(4, null, new(1, new(2)))), null),
         new TreeNode(2, null, new TreeNode(2, null, new(1, null, new(4, new(2))))));
        Assert.That(new Solution().IsSymmetric(right), Is.EqualTo(false));
    }
}
