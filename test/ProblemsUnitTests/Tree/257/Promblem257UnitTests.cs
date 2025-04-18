using NUnit.Framework;
using LeetCode.Problems.Tree;
using LeetCode.Problems.Tree._257;

namespace ProblemsUnitTests.Tree._257;

public class Promblem257UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test3()
    {
        //[1,2,3,null,5]
        var root = new TreeNode(1, new(2, null, new(5)), new(3));
        List<string> expected = ["1->2->5", "1->3"];
        Assert.That(new Solution().BinaryTreePaths(root), Is.EqualTo(expected));
    }
}
