using LeetCode.Problems._2962;

namespace ProblemsUnitTests._2962;

public class Problem2962UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, int k, long expected) td)
    {
        Assert.That(new Solution().CountSubarrays(td.input, td.k), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int, long)> GetTestCaseDatas()
    {
        yield return ([1, 3, 2, 3, 3], 2, 6);
        yield return ([1, 3, 2, 3, 3], 1, 13);
        yield return ([1, 4, 2, 1], 3, 0);
        yield return ([3], 1, 1);
        yield return ([1], 100, 0);
        yield return ([28, 5, 58, 91, 24, 91, 53, 9, 48, 85, 16, 70, 91, 91, 47, 91, 61, 4, 54, 61, 49], 1, 187);
        yield return ([1, 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3,
                        3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3], 2, 1221);
        yield return ([1, 3, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3,
                        3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3], 1, 1273);
    }

}
