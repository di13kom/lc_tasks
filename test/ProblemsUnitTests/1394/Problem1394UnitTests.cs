using LeetCode.Problems._1394;

namespace ProblemsUnitTests._1394;

public class Problem1394UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, int expected) td)
    {
        Assert.That(new Solution().FindLucky(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int)> GetTestCaseDatas()
    {
        yield return ([2, 2, 3, 4], 2);
        yield return ([1, 2, 2, 3, 3, 3], 3);
        yield return ([2, 2, 2, 3, 3], -1);
        yield return ([4, 3, 2, 2, 4, 1, 3, 4, 3], 3);
    }
}
