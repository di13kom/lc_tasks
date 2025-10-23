using System.Collections;
using LeetCode.Problems.Tree;
using LeetCode.Problems.Tree._95;
using NUnit.Framework.Legacy;

namespace ProblemsUnitTests.Tree._95;

public class Problem95UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int input, IEnumerable<IEnumerable<int?>> expected) td)
    {
        var res = new Solution().GenerateTrees(td.input);
        List<IEnumerable<int?>> ints = [];
        foreach (var item in res)
        {
            ints.Add(TreeNodeFactory.CreateEnumerableFromBinaryTreeNode(item));
        }
        Assert.That(td.expected, Is.EquivalentTo(ints));
    }
    private static IEnumerable<(int, IEnumerable<IEnumerable<int?>>)> GetTestCaseDatas()
    {
        yield return (3, [[1, null, 2, null, 3], [1, null, 3, 2], [2, 1, 3], [3, 1, null, null, 2], [3, 2, null, 1]]);
        yield return (1, [[1]]);
    }
}