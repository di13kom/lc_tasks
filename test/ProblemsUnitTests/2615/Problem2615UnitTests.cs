using LeetCode.Problems._2615;

namespace ProblemsUnitTests._2615;

[Timeout(10000)]
public class Problem2615UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, long[] expected) td)
    {
        Assert.That(new Solution().Distance(td.input), Is.EqualTo(td.expected));
    }
    private static IEnumerable<(int[], long[])> GetTestCaseDatas()
    {
        yield return ([1, 3, 1, 1, 2], [5, 0, 3, 4, 0]);
        yield return ([1, 3, 3, 1, 2], [3, 1, 1, 3, 0]);
        yield return ([1, 3, 1, 4, 2], [2, 0, 2, 0, 0]);
        yield return ([0, 5, 3], [0, 0, 0]);
        yield return ([1, 1, 1, 1, 1], [10, 7, 6, 7, 10]);//0+1+2+3+4
        yield return ([4, 1, 1, 1, 1, 1], [0, 10, 7, 6, 7, 10]);//1+2+3+4+5
        yield return ([1, 1, 1, 1, 1, 4], [10, 7, 6, 7, 10, 0]);
        yield return ([1, 3, 3, 3, 3], [0, 6, 4, 4, 6]);
        yield return ([3, 3, 5, 3, 3], [8, 6, 0, 6, 8]);
        yield return ([3, 7, 5, 3, 3, 5, 5], [7, 0, 7, 4, 5, 4, 5]);
        yield return ([3, 3, 5, 3, 3, 5], [8, 6, 3, 6, 8, 3]);
        yield return ([3, 3, 5, 3, 3, 5, 3], [14, 11, 3, 9, 10, 3, 16]);
        yield return ([3, 3, 5, 3, 3, 5, 5], [8, 6, 7, 6, 8, 4, 5]);
        //yield return (Enumerable.Repeat((int)1E9, (int)1E6).ToArray(), Enumerable.Repeat(0L, (int)1E6).ToArray());
    }
}