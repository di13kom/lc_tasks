using LeetCode.Problems._1390;

namespace ProblemsUnitTests._1390;

public class Problem1390UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, int expected) td)
    {
        Assert.That(new Solution().SumFourDivisors(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int)> GetTestCaseDatas()
    {
        yield return ([21, 4, 7], 32);
        yield return ([21, 21], 64);
        yield return ([1, 2, 3, 4, 5], 0);

        yield return ([16, 21, 4, 7], 32);
        yield return ([6, 8, 10, 14], 69);
        yield return ([15, 16, 17, 18], 24);
        yield return ([33, 22, 26, 27, 28], 166);
        yield return ([6, 10, 14, 15, 21, 22, 26, 33, 35, 38, 39, 46, 51, 55, 57, 58, 62, 65, 69, 74], 1176);
    }
}
