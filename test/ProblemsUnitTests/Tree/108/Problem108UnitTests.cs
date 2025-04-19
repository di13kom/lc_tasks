using LeetCode.Problems.Tree;
using LeetCode.Problems.Tree._108;

namespace ProblemsUnitTests._108;

public class Problem108UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var root = new TreeNode(0, 
                                new(-10, new(-3)),
                                new(5, null, new(9)));
        int[] array = [-10,-3,0,5,9];
        Assert.That(new Solution().SortedArrayToBST(array), Is.EqualTo(root));
    }

    [Test]
    public void Test2()
    {
        var root = new TreeNode(1, new(3));
        int[] array = [1,3];
        Assert.That(new Solution().SortedArrayToBST(array), Is.EqualTo(root));
    }

    //[Test]
    public void Test3()
    {
        var root = new TreeNode(1, new(3));
        int[] array = [1,3];
        Assert.That(new Solution().SortedArrayToBST(array), Is.EqualTo(root));
    }
}
