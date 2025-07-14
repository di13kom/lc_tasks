using LeetCode.Problems._1290;
using LeetCode.Problems.Common;

using static LeetCode.Problems.Common.ListNodeExtension;

namespace ProblemsUnitTests._1290;

public class Problem1290UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((ListNode input, int expected) td)
    {
        Assert.That(new Solution().GetDecimalValue(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(ListNode, int)> GetTestCaseDatas()
    {
        yield return (ArrayToListNode([1, 0, 1]), 5);
        yield return (ArrayToListNode([0]), 0);
        yield return (ArrayToListNode([0, 1, 1, 1, 1, 0, 1, 1]), 123);
        yield return (ArrayToListNode([1, 0, 0, 1, 1, 0, 1, 0, 1, 1, 0, 0, 0, 0, 0, 1, 1 ,1, 0, 0, 0 ,1, 0, 1, 1 ,0, 1, 0, 1]), 324548789);
    }
}