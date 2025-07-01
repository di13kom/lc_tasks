using LeetCode.Problems._35;

namespace ProblemsUnitTests._35;

public class Problem35UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, int value, int expected) td)
    {
        Assert.That(new Solution().SearchInsert(td.input, td.value), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int, int)> GetTestCaseDatas()
    {
        yield return ([1, 3, 5, 6], 5, 2);
        yield return ([1, 3, 5, 6], 2, 1);
        yield return ([1, 3, 5, 6], 7, 4);
        yield return ([1, 3, 5, 6], 3, 1);
        yield return ([1], 1, 0);
    }
}