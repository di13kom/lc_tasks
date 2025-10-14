using LeetCode.Problems._3583;

namespace ProblemsUnitTests._3583;

public class Problem3583UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, int expected) td)
    {
        Assert.That(new Solution().SpecialTriplets(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int)> GetTestCaseDatas()
    {
        yield return ([6, 3, 6], 1);
        yield return ([0, 1, 0, 0], 1);
        yield return ([8, 4, 2, 8, 4], 2);
        yield return ([84, 2, 93, 1, 2, 2, 26], 2);
        yield return (Enumerable.Repeat(0, 640).ToArray(), 43486080);
    }
}
