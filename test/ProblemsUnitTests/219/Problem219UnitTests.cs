using LeetCode.Problems._219;

namespace ProblemsUnitTests._219;

public class Problem219UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input1, int k, bool expected) td)
    {
        Assert.That(new Solution().ContainsNearbyDuplicate(td.input1, td.k), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int, bool)> GetTestCaseDatas()
    {
        yield return ([1, 2, 3, 1], 3, true);
        yield return ([1, 0, 1, 1], 1, true);
        yield return ([1, 2, 3, 1, 2, 3], 2, false);
    }
}