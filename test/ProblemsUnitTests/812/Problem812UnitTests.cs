using LeetCode.Problems._812;

namespace ProblemsUnitTests._812;

public class Problem812UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[][] input, double expected) td)
    {
        Assert.That(new Solution().LargestTriangleArea(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[][], double)> GetTestCaseDatas()
    {
        yield return ([[0, 0], [0, 2], [2, 0]], 2.00000);
        yield return ([[0, 0], [0, 1], [1, 0], [0, 2], [2, 0]], 2.00000);
        yield return ([[1, 0], [0, 0], [0, 1]], 0.50000);
        yield return ([[-35, 19], [40, 19], [27, -20], [35, -3],
                        [44, 20], [22, -21], [35, 33], [-19, 42], [11, 47], [11, 37]], 1799.00d);
        yield return ([[-3, 17], [-36, -41], [22, 14], [-18, -38], [15, -25], [42, 4], [-28, 6]], 1653.00d);
        yield return ([[-15, 33], [7, 7], [12, 26], [25, -23],
                        [32, -1], [-32, -18], [-46, 28], [10, -48],
                        [-11, -48], [14, 13], [14, -45], [32, 6], [36, 41]], 3480.00d);
        yield return ([[11, 13], [-37, 48], [-29, -14], [41, -16], [-24, 44]], 2162.00d);
        yield return ([[-34, 49], [-45, -11], [46, 27], [-46, -4], [37, -41], [34, -50]], 3356.00d);
        yield return ([[-48, 45], [-6, 49], [-31, -45], [1, -5], [-36, -16], [2, 6], [-39, 32], [25, -15]], 2775.00d);
    }
}
