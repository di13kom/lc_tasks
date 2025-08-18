using LeetCode.Problems._3363;

namespace ProblemsUnitTests._3363;

[Timeout(10000)]
public class Problem3363UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[][] fruits, int expected) td)
    {
        Assert.That(new Solution().MaxCollectedFruits(td.fruits), Is.EqualTo(td.expected));
    }
    private static IEnumerable<(int[][], int)> GetTestCaseDatas()
    {
        yield return ([[1, 2, 3, 4], [5, 6, 8, 7], [9, 10, 11, 12], [13, 14, 15, 16]], 100);
        yield return ([[1, 1], [1, 1]], 4);
        yield return ([[16, 9, 1, 2, 3], [5, 14, 12, 1, 13], [3, 12, 20, 3, 10], [12, 1, 16, 5, 13], [2, 19, 11, 9, 10]], 150);
        yield return (createArray(10), 1810);
    }

    private static int[][] createArray(int capacity)
    {
        int bigInt = capacity;
        var bigArray = new int[bigInt][];
        for (int i = 0; i < bigInt; i++)
        {
            bigArray[i] = Enumerable.Range(bigInt * i + 1, bigInt).ToArray();
        }

        return bigArray;
    }
}
