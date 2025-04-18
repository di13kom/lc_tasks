using NUnit.Framework;
using LeetCode.Problems._2;
using System.Text;

namespace ProblemsUnitTests._2;

public class Problem2UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        ListNode lst1 = new(2, new(3, new(4)));
        ListNode lst2 = new(9, new(2, new(5)));
        ListNode expectd = new(1, new(6, new(9)));
        var result = new Solution().AddTwoNumbers(lst1, lst2);
        Assert.That(PrintListNode(result), Is.EqualTo(PrintListNode(expectd)));
    }

    [Test]
    public void Test2()
    {
        ListNode lst1 = new(9, new(9, new(6)));
        ListNode lst2 = new(9, new(2, new(5)));
        ListNode expectd = new(8, new(2, new(2, new(1))));
        var result = new Solution().AddTwoNumbers(lst1, lst2);
        Assert.That(PrintListNode(result), Is.EqualTo(PrintListNode(expectd)));
    }
    [Test]
    public void Test3()
    {
        ListNode lst1 = new(9, new(9, new(6,new(6,new(6)))));
        ListNode lst2 = new(9, new(2, new(5)));
        ListNode expectd = new(8, new(2, new(2, new(7,new(6)))));
        var result = new Solution().AddTwoNumbers(lst1, lst2);
        Assert.That(PrintListNode(result), Is.EqualTo(PrintListNode(expectd)));
    }

    private string PrintListNode(ListNode lst)
    {
        StringBuilder str = new StringBuilder();
        while (lst != null)
        {
            str.Append(lst.val);
            lst = lst.next;
        }

        return str.ToString();
    }
}
