using LeetCode.Problems._3318;

namespace ProblemsUnitTests._3318;

public class Problem3318UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, int k, int x, int[] expected) td)
    {
        Assert.That(new Solution().FindXSum(td.input, td.k, td.x), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int, int, int[])> GetTestCaseDatas()
    {
        yield return ([1, 4, 4, 4], 3, 2, [9, 12]);
        yield return ([1, 1, 2, 2, 3, 4, 2, 3], 6, 2, [6, 10, 12]);
        yield return ([3, 8, 7, 8, 7, 5], 2, 2, [11, 15, 15, 15, 12]);
        yield return ([1, 2, 3, 4, 5], 3, 3, [6, 9, 12]);
        yield return ([1, 2, 3, 4, 5, 6, 7, 9, 7, 7, 10, 12, 45, 50, 21, 45, 24, 12, 36, 14, 7, 6, 14, 42, 49, 47, 48, 46, 43, 42, 41, 30, 3, 5, 35, 36, 39, 38, 37],
                        21,
                        5,
        [228, 204, 182, 182, 182, 182, 220, 213, 213, 240, 276, 276, 301, 259, 256, 281, 281, 281, 281]);
        yield return ([1], 1, 1, [1]);
        yield return ([2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2], 10, 1, [20, 20, 20, 20, 20, 20]);
        yield return ([25, 26, 27, 28, 29, 30, 19, 18, 17, 16, 15, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 25, 26, 27, 28, 29, 30, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10],
                        25,
                        25,
                        [421, 423, 425, 427, 429, 419, 407, 405, 403, 401, 399, 397, 399, 400, 400, 400, 400, 400, 400, 400, 400, 400, 400, 400, 385, 369]);
    }
}
