using LeetCode.Problems.PrefixSum._3147;

namespace ProblemsUnitTests.PrefixSum._3147;

public class Problem3147UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] energy, int k, int expected) td)
    {
        Assert.That(new Solution().MaximumEnergy(td.energy, td.k), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int, int)> GetTestCaseDatas()
    {
        yield return ([8, -5], 1, 3);
        yield return ([5, 2, -10, -5, 1], 3, 3);
        yield return ([-2, -3, -1], 2, -1);
        yield return ([441, 844, -818, -46, 393, 766], 3, 1237);
        yield return ([-85, 375, 50, 151, -147, 74, 769, 165, 785, 363, 239, 296,
                        -634, 928, -520, 989, -70, 313, 575, 910, -56, -153, 11, 191, 213],
                        8,
                        1357);
    }
}
