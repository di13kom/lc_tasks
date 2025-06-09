using LeetCode.Problems._2016;

namespace ProblemsUnitTests._2016;

public class Problem2016UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Test1((int[] input, int expected) td)
    {
        Assert.That(new Solution().MaximumDifference(td.input), Is.EqualTo(td.expected));
    }
    private static IEnumerable<(int[], int)> GetTestCaseDatas()
    {
        yield return (new int[] { 7, 1, 5, 4 }, 4);
        yield return (new int[] { 9, 4, 3, 2 }, -1);
        yield return (new int[] { 9, 2, 3, 8 }, 6);
        yield return (new int[] { 1, 5, 2, 10 }, 9);
        yield return (new int[] { 87, 68, 91, 86, 58, 63, 43, 98, 6, 40 }, 55);
    }
}
