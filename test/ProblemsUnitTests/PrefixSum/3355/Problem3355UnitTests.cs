using LeetCode.Problems.PrefixSum._3355;


namespace ProblemsUnitTests.PrefixSum._3355;

public class Problem3355UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(new int[] { 1, 0, 1 }, new int[] { 0, 2 }, true)]
    [TestCase(new int[] { 4, 3, 2, 1 }, new int[] { 1, 3, 0, 2 }, false)]
    public void Test1(int[] input, int[] queries_, bool expected)
    {
        int[][] queries = new int[queries_.Length / 2][];

        for (int i = 0; i < queries_.Length; i += 2)
        {
            queries[i / 2] = new int[2] { queries_[i], queries_[i + 1] };
        }
        Assert.That(new Solution().IsZeroArray(input, queries), Is.EqualTo(expected));
    }
}
