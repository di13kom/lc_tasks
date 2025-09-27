using LeetCode.Problems._1578;

namespace ProblemsUnitTests._1578;

public class Problem1578UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((string colors, int[] neededTime, int expected) td)
    {
        Assert.That(new Solution().MinCost(td.colors, td.neededTime), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(string, int[], int)> GetTestCaseDatas()
    {
        yield return ("abaac", [1, 2, 3, 4, 5], 3);
        yield return ("abc", [1, 2, 3], 0);
        yield return ("aabaa", [1, 2, 3, 4, 1], 2);
        yield return ("abcde",[1234, 5678, 910, 1112, 1314], 0);
        yield return ("aaabbccdde", [10000, 5000, 7000, 2000, 3000, 6000, 4000, 8000, 9000, 1000], 26000);
        yield return ("zzzyyyxxxwwv", [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12], 37);
        yield return ("mnopqrstu", [9999, 8888, 7777, 6666, 5555, 4444, 3333, 2222, 1111], 0);
        yield return ("aaaabbbbcccc", [10000, 1, 9999, 2, 8888, 3, 7777, 4, 6666, 5, 5555, 6], 23352);
        yield return ("abababababab", [1234, 5678, 910, 1112, 1314, 1516, 1718, 1920, 2122, 2324, 2526, 2728], 0);
        yield return ("ccccccdddddd", [5000, 10000, 7500, 1250, 625, 312, 156, 78, 39, 19, 10, 5], 14838);
        yield return ("xyzxyzxyzxyz", [10000, 1, 9999, 2, 8888, 3, 7777, 4, 6666, 5, 5555, 6], 0);
    }
}
