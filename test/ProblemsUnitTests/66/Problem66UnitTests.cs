using LeetCode.Problems._66;

namespace ProblemsUnitTests._66;

public class Problem66UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, int[] expected) td)
    {
        Assert.That(new Solution().PlusOne(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int[])> GetTestCaseDatas()
    {
        yield return ([1, 2, 3], [1, 2, 4]);
        yield return ([4, 3, 2, 1], [4, 3, 2, 2]);
        yield return ([9], [1, 0]);
        yield return ([1, 9, 9], [2, 0, 0]);
        yield return ([9, 9], [1, 0, 0]);
    }
}