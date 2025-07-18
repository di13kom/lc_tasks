using LeetCode.Problems._83;
using LeetCode.Problems.Common;
using static LeetCode.Problems.Common.ListNodeExtension;

namespace ProblemsUnitTests._83;

public class Problem83UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((ListNode input, ListNode expected) td)
    {
        Assert.That(ListNodeToArray(new Solution().DeleteDuplicates(td.input)), Is.EqualTo(ListNodeToArray(td.expected)));
    }

    private static IEnumerable<(ListNode, ListNode)> GetTestCaseDatas()
    {
        yield return (ArrayToListNode([1, 1, 2]), ArrayToListNode([1, 2]));
        yield return (ArrayToListNode([1, 1, 2, 3, 3]), ArrayToListNode([1, 2, 3]));
        yield return (ArrayToListNode([1, 1, 2, 2, 2]), ArrayToListNode([1, 2]));
        yield return (ArrayToListNode([1, 1, 1, 1, 1]), ArrayToListNode([1]));

    }
}