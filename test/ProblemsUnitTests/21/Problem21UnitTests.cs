using LeetCode.Problems._21;
using LeetCode.Problems.Common;
using static LeetCode.Problems.Common.ListNodeExtension;

namespace ProblemsUnitTests._21;

public class Problem21UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((ListNode input1, ListNode input2, ListNode expected) td)
    {
        Assert.That(ListNodeToArray(new Solution().MergeTwoLists(td.input1, td.input2)), Is.EqualTo(ListNodeToArray(td.expected)));
    }

    private static IEnumerable<(ListNode, ListNode, ListNode)> GetTestCaseDatas()
    {
        yield return (ArrayToListNode([1, 2, 4]), ArrayToListNode([1, 3, 4]), ArrayToListNode([1, 1, 2, 3, 4, 4]));
        yield return (ArrayToListNode([]), ArrayToListNode([]), ArrayToListNode([]));
        yield return (ArrayToListNode([]), ArrayToListNode([0]), ArrayToListNode([0]));
    }
}
