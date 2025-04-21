using NUnit.Framework;
using LeetCode.Problems.DivideAndConquer._169;

namespace ProblemsUnitTests.DivideAndConquer._169;

public class Problem169UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase(new int[]{3,2,3} , 3)]
    [TestCase(new int[]{2,2,1,1,1,2,2} , 2)]
    public void Test1(int[] array, int expected)
    {
        Assert.That(new Solution().MajorityElement(array), Is.EqualTo(expected));
    }
}
