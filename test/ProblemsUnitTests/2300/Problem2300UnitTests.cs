using LeetCode.Problems._2300;

namespace ProblemsUnitTests._2300;

public class Problem2300UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] spells, int[] potions, long success, int[] expected) td)
    {
        Assert.That(new Solution().SuccessfulPairs(td.spells, td.potions, td.success), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int[], long, int[])> GetTestCaseDatas()
    {
        yield return ([5, 1, 3], [1, 2, 3, 4, 5], 7, [4, 0, 3]);
        yield return ([3, 1, 2], [8, 5, 8], 16, [2, 0, 2]);
        yield return ([40, 11, 24, 28, 40, 22, 26, 38, 28, 10, 31, 16, 10, 37, 13, 21, 9, 22, 21, 18, 34, 2, 40, 40, 6, 16, 9, 14, 14, 15, 37, 15, 32, 4, 27, 20, 24, 12, 26, 39, 32, 39, 20, 19, 22, 33, 2, 22, 9, 18, 12, 5],
                        [31, 40, 29, 19, 27, 16, 25, 8, 33, 25, 36, 21, 7, 27, 40, 24, 18, 26, 32, 25, 22, 21, 38, 22, 37, 34, 15, 36, 21, 22, 37, 14, 31, 20, 36, 27, 28, 32, 21, 26, 33, 37, 27, 39, 19, 36, 20, 23, 25, 39, 40],
                            600,
                        [48, 0, 32, 37, 48, 22, 33, 47, 37, 0, 43, 6, 0, 46, 0, 21, 0, 22, 21, 14, 46, 0, 48, 48, 0, 6, 0, 0, 0, 3, 46, 3, 45, 0, 34, 20, 32, 0, 33, 47, 45, 47, 20, 18, 22, 45, 0, 22, 0, 14, 0, 0]);
        yield return ([3, 1, 2], [8, 5, 8], 2966799365, [0, 0, 0]);
        //yield return (Enumerable.Range(1, 10_000).ToArray(), Enumerable.Range(1, 10_000).ToArray(), 39370078, Enumerable.Repeat(0, 10_000).ToArray());
    }
}
