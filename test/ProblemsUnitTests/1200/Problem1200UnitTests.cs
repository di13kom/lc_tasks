using LeetCode.Problems._1200;

namespace ProblemsUnitTests._1200;

public class Problem1200UnitTests
{
    [SetUp]
    public void Setup()
    {
    }


    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, IList<IList<int>> expected) td)
    {
        Assert.That(new Solution().MinimumAbsDifference(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], IList<IList<int>>)> GetTestCaseDatas()
    {
        yield return ([4, 2, 1, 3], [[1, 2], [2, 3], [3, 4]]);
        yield return ([1, 3, 6, 10, 15], [[1, 3]]);
        yield return ([3, 8, -10, 23, 19, -4, -14, 27], [[-14, -10], [19, 23], [23, 27]]);
        yield return ([1, 3], [[1, 3]]);
    }
}


