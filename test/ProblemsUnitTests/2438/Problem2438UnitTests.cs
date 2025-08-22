using LeetCode.Problems._2438;

namespace ProblemsUnitTests._2438;

public class Problem2438UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int input, int[][] queries, int[] expected) td)
    {
        Assert.That(new Solution().ProductQueries(td.input, td.queries), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int, int[][], int[])> GetTestCaseDatas()
    {
        yield return (15, [[0, 1], [2, 2], [0, 3]], [2, 4, 64]);
        yield return (2, [[0, 0]], [2]);
        yield return (123444423, [[6, 14], [0, 0]], [263370793, 1]);
        yield return (333444320, [[11, 14], [5, 12], [2, 5], [2, 13], [12, 14]], [946258191, 474116404, 46480318, 210575101, 164688009]);
        yield return (934344340, [[8, 11], [13, 13], [6, 13], [9, 9], [8, 12],
                            [0, 11], [7, 9], [4, 11], [10, 10], [13, 13],
                            [2, 4], [11, 11], [6, 9], [13, 13], [10, 11],
                            [5, 10], [8, 11], [5, 5]],
                            [248320570,33554432,631685400,1048576,810970231,769740174,
                                949480669,279632277,2097152,33554432,67108864,8388608,
                                145586002,33554432,185921272,936761609,248320570,4096]);
    }
}
