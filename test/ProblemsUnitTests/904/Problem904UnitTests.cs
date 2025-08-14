using LeetCode.Problems._904;

namespace ProblemsUnitTests._904;

public class Problem904UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, int expected) td)
    {
        Assert.That(new Solution().TotalFruit(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int)> GetTestCaseDatas()
    {
        yield return ([1, 2, 1], 3);
        yield return ([0, 1, 2, 2], 3);
        yield return ([1, 2, 3, 2, 2], 4);
        yield return ([1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1, 2], 20);
        yield return ([1, 2, 3, 2, 2, 3, 3, 2, 1, 1, 2, 3, 3, 2, 2, 1, 1, 3], 7);
        yield return ([7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7], 30);
        yield return ([3, 3, 3, 1, 2, 1, 2, 1, 2, 3, 1, 1, 2, 2, 1, 3, 3, 2, 2, 3, 1, 2], 6);
        yield return ([4, 5, 4, 5, 4, 5, 4, 5, 4, 5, 4, 5, 4, 5, 4, 5], 16);
        yield return ([1, 2, 3, 2, 3, 2, 3, 2, 4, 4, 4, 5, 5, 5, 4, 4, 3, 3, 2, 2], 8);
        yield return ([8, 9, 8, 9, 8, 7, 9, 8, 9, 8, 9, 8, 9, 7, 8, 9, 8, 9, 8], 7);
        yield return ([1, 1, 2, 3, 2, 3, 3, 3, 2, 2, 4, 4, 4, 4, 4, 3, 3, 2, 2, 2], 8);
    }
}
