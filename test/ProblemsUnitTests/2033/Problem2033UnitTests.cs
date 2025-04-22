using NUnit.Framework;
using LeetCode.Problems._2033;

namespace ProblemsUnitTests._2033;

public class Problem2033UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    //#pragma warning disable NUnit1003
    //[TestCase(new int[2][] { new int[2] { 2, 4 }, new int[2] { 6, 8 } }, 2, 4)]
    //#pragma warning disable NUnit1003
    //public void Test1(int[][] input, int intVal, int expected)
    public void Test1()
    {
        int[][] input = [[2, 4], [6, 8]];
        int intVal = 2;
        int expected = 4;
        Assert.That(new Solution().MinOperations(input, intVal), Is.EqualTo(expected));
    }

    [Test]
    public void Test2()
    {
        int[][] input = [[1, 5], [2, 3]];
        int intVal = 1;
        int expected = 5;
        Assert.That(new Solution().MinOperations(input, intVal), Is.EqualTo(expected));
    }

    [Test]
    public void Test3()
    {
        int[][] input = [[1, 2], [3, 4]];
        int intVal = 2;
        int expected = -1;
        Assert.That(new Solution().MinOperations(input, intVal), Is.EqualTo(expected));
    }

    [Test]
    public void Test4()
    {
        int[][] input = [[146]];
        int intVal = 86;
        int expected = 0;
        Assert.That(new Solution().MinOperations(input, intVal), Is.EqualTo(expected));
    }

    [Test]
    public void Test5()
    {
        int[][] input = [[980, 476, 644, 56], [644, 140, 812, 308], [812, 812, 896, 560], [728, 476, 56, 812]];
        int intVal = 84;
        int expected = 45;
        Assert.That(new Solution().MinOperations(input, intVal), Is.EqualTo(expected));
    }
    [Test]
    public void Test6()
    {
        int[][] input = [[52, 302, 202, 52, 252, 452], [702, 52, 452, 102, 52, 852], [302, 202, 752, 702, 702, 402], [502, 52, 52, 302, 452, 152], [452, 252, 2, 502, 702, 452], [402, 652, 702, 402, 752, 452]];
        int intVal = 50;
        int expected = 149;
        Assert.That(new Solution().MinOperations(input, intVal), Is.EqualTo(expected));
    }
    [Test]
    public void Test7()
    {
        int[][] input = [[141, 105, 69, 273, 681, 105, 933, 417, 309], [921, 657, 945, 717, 885, 57, 453, 921, 897], [681, 345, 657, 177, 897, 609, 465, 801, 429], [681, 993, 741, 885, 105, 981, 477, 249, 921], [369, 885, 945, 537, 45, 861, 381, 345, 417], [849, 849, 477, 513, 297, 609, 561, 177, 801], [561, 417, 129, 585, 621, 561, 261, 153, 501], [249, 777, 969, 249, 357, 393, 93, 321, 573], [525, 813, 381, 909, 825, 297, 681, 345, 813]];
        int intVal = 12;
        int expected = 1632;
        Assert.That(new Solution().MinOperations(input, intVal), Is.EqualTo(expected));
    }
}
