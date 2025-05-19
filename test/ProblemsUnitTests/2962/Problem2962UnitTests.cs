using LeetCode.Problems._2962;
namespace ProblemsUnitTests._2962;

public class Problem2962UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(new int[] { 1, 3, 2, 3, 3 }, 2, 6)]
    [TestCase(new int[] { 1, 4, 2, 1 }, 3, 0)]
    [TestCase(new int[] { 3 }, 1, 1)]
    public void Test(int[] input, int k, long expected)
    {
        Assert.That(new Solution().CountSubarrays(input, k), Is.EqualTo(expected));
    }
}
