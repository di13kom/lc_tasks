using NUnit.Framework;
using LeetCode.Problems._2099;

namespace ProblemsUnitTests._2099;

public class Problem2099UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, int k, int[] expected) td)
    {
        Assert.That(new Solution().MaxSubsequence(td.input, td.k), Is.EqualTo(td.expected));
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Solution1Test((int[] input, int k, int[] expected) td)
    {
        Assert.That(new Solution1().MaxSubsequence(td.input, td.k), Is.EqualTo(td.expected));
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Solution2Test((int[] input, int k, int[] expected) td)
    {
        Assert.That(new Solution2().MaxSubsequence(td.input, td.k), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int, int[])> GetTestCaseDatas()
    {
        yield return ([2, 1, 3, 3], 2, [3, 3]);
        yield return ([-1, -2, 3, 4], 3, [-1, 3, 4]);
        yield return ([3, 4, 3, 3], 2, [3, 4]);
        yield return ([1, 1000, 2, 999, 3], 3, [1000, 999, 3]);
        yield return ([4, 1, 7, 2, 9], 5, [4, 1, 7, 2, 9]);
        yield return ([-16, -13, 8, 16, 35, -17, 30, -8, 34, -2, -29, -35, 15, 13, -30, -34, 6, 15, 28, -23, 34, 28, -24, 15, -17, 10, 31, 32, -3, -36, 19, 31, -5, -21, -33, -18, -23, -37, -15, 12, -28, -40, 1, 38, 38, -38, 33, -35, -28, -40, 4, -15, -29, -33, -18, -9, -29, 20, 1, 36, -8, 23, -34, 16, -7, 13, 39, 38, 7, -7, -10, 30, 9, 26, 27, -37, -18, -25, 14, -36, 23, 28, -15, 35, -9, 1]
                        , 8, [35, 34, 38, 38, 36, 39, 38, 35]);
    }
}