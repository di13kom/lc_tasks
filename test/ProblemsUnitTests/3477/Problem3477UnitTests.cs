using LeetCode.Problems._3477;

namespace ProblemsUnitTests._3477;

public class Problem3477UnitTests
{
    [SetUp]
    public void Setup()
    {
    }


    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] fruits, int[] basket2, long expected) td)
    {
        Assert.That(new Solution().NumOfUnplacedFruits(td.fruits, td.basket2), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int[], long)> GetTestCaseDatas()
    {
        yield return ([4, 2, 5], [3, 5, 4], 1);
        yield return ([3, 6, 1], [6, 4, 7], 0);
        yield return ([804, 145, 204, 705, 357, 601], [957, 286, 88, 929, 899, 856], 1);
    }
}
