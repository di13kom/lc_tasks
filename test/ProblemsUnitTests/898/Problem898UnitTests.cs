using LeetCode.Problems._898;

namespace ProblemsUnitTests._898;

public class Problem898UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas)), Timeout(10000)]
    public void SolutionTest((int[] cnt, int expected) td)
    {
        Assert.That(new Solution().SubarrayBitwiseORs(td.cnt), Is.EqualTo(td.expected));
    }
    private static IEnumerable<(int[], int)> GetTestCaseDatas()
    {
        yield return ([0], 1);
        yield return ([1, 1, 2], 3);
        yield return ([1, 2, 4], 6);
        yield return ([39, 19, 30, 56, 79, 50, 19, 70, 30], 17);
        yield return (Enumerable.Repeat(0, (int)1E4).Append(2).ToArray(), 2);
    }
}
