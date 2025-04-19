using LeetCode.Problems.Tree;
using LeetCode.Problems.Tree._222;

namespace ProblemsUnitTests._222;

public class Problem222UnitTests
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
                                new(2));
        Assert.That(new Solution().CountNodes(root), Is.EqualTo(8));
    }
}
