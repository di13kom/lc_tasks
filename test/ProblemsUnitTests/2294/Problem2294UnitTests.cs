using NUnit.Framework;
using LeetCode.Problems._2294;
using NUnit.Framework.Internal;

namespace ProblemsUnitTests._2294;

public class Problem2294UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Solution_test((int[] input, int k, int expected) td)
    {
        Assert.That(new Solution().PartitionArray(td.input, td.k), Is.EqualTo(td.expected));
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Solution1_test((int[] input, int k, int expected) td)
    {
        Assert.That(new Solution1().PartitionArray(td.input, td.k), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int, int)> GetTestCaseDatas()
    {
        yield return ([3, 6, 1, 2, 5], 2, 2);
        yield return ([1, 2, 3], 1, 2);
        yield return ([2, 2, 4, 5], 0, 3);
        yield return ([0], 1, 1);
        yield return ([680, 625, 316, 967, 784, 601, 300, 319, 550, 373, 89, 632, 36, 888, 580, 349, 94, 793, 40, 644], 50, 10);
        yield return (Enumerable.Range(0, 100_000).ToArray(), 51_688, 2);
        yield return (Enumerable.Range(0, 100_000).ToArray(), 0, 100_000);
        yield return ([2, 0], 1, 2);
        yield return (Enumerable.Range(0, 10_000).ToArray(), 9766, 2);
        yield return (Enumerable.Range(4200, 4066).ToArray(), 7766, 1);
    }
}