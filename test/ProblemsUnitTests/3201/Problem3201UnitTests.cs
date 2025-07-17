using LeetCode.Problems._3201;

namespace ProblemsUnitTests._3201;

public class Problem3201UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, int expected) td)
    {
        Assert.That(new Solution().MaximumLength(td.input), Is.EqualTo(td.expected));
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Solution1Test((int[] input, int expected) td)
    {
        Assert.That(new Solution1().MaximumLength(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int)> GetTestCaseDatas()
    {
        yield return ([1, 2, 3, 4], 4);
        yield return ([1, 2, 1, 1, 2, 1, 2], 6);
        yield return ([1, 3], 2);
        yield return ([2, 4], 2);
        yield return ([1, 2, 3, 4, 6, 8, 10], 5);
        yield return ([1, 2, 3, 4, 5, 7, 9, 11], 6);
        yield return ([38, 78, 42, 23, 93, 38, 100, 3, 81, 79, 52, 67, 29, 50,
                        54, 67, 54, 15, 21, 52, 40, 6, 98, 77, 98, 43, 88, 84,
                        85, 98, 50, 27, 85, 31, 75, 13, 69, 61, 26, 93, 43, 29,
                        92, 86, 1, 34, 89, 5, 32, 69, 45, 6, 17, 72, 60, 17, 40,
                        24, 30, 33, 35, 50, 6, 52, 37, 1, 88, 10, 25, 47, 89, 23,
                        82, 34, 61, 22, 79, 59, 95, 19, 93, 64, 71, 95, 8, 75, 25,
                        99, 10, 42, 72, 100, 62, 5, 68, 71, 20, 78, 27, 81], 53);
        yield return ([1, 5, 9, 4, 2], 3);
        yield return ([1, 7, 8, 7, 5], 4);
        yield return ([4, 51, 68], 3);
        yield return (Enumerable.Range(1, 100000).ToArray(), 100000);
    }
}