using LeetCode.Problems._141;
using LeetCode.Problems.Common;
using static LeetCode.Problems.Common.ListNodeExtension;

namespace ProblemsUnitTests._141;

public class Problem141UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((ListNode input, bool expected) td)
    {
        Assert.That(new Solution().HasCycle(td.input), Is.EqualTo(td.expected));
    }
    
    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Solution1Test((ListNode input, bool expected) td)
    {
        Assert.That(new Solution1().HasCycle(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(ListNode, bool)> GetTestCaseDatas()
    {
        var array = ArrayToListNode([1, 2, 3, 2]);
        array.next.next.next = array;
        var array1 = ArrayToListNode([1, 2, 3, 2, 4, 5]);
        array1.next.next.next.next.next = array1.next;
        var array2 = ArrayToListNode([-1, -7, 7, -4, 19, 6, -9, -5, -2, -5]);
        array2.next.next.next.next.next.next.next.next.next = array2.next.next.next.next.next.next.next;

        yield return (ArrayToListNode([1]), false);
        yield return (ArrayToListNode([1, 2]), false);
        yield return (array, true);
        yield return (array1, true);
        yield return (array2, true);
    }
}
