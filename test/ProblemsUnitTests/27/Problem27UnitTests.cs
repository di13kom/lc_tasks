using LeetCode.Problems._27;

namespace ProblemsUnitTests._27;

public class Problem27UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, int val, int expected, int[] expectedArray) td)
    {
        Assert.Multiple(() =>
        {
            Assert.That(new Solution().RemoveElement(td.input, td.val), Is.EqualTo(td.expected));
            Assert.That(td.input.Take(td.expected), Is.EqualTo(td.expectedArray));
        });
    }

    private static IEnumerable<(int[], int, int, int[])> GetTestCaseDatas()
    {
        yield return ([3, 2, 2, 3], 3, 2, [2, 2]);
        yield return ([0, 1, 2, 2, 3, 0, 4, 2], 2, 5, [0, 1, 4, 0, 3]);
        yield return ([3, 3, 3, 1], 3, 1, [1]);
        yield return ([1, 2, 3, 4], 3, 3, [1, 2, 4]);
        yield return ([3, 3, 3, 3], 3, 0, []);
        yield return ([3, 3, 1, 3], 3, 1, [1]);
        yield return ([1, 3, 1, 3], 3, 2, [1, 1]);
        yield return ([1, 3, 1, 1], 3, 3, [1, 1, 1]);
        yield return ([], 0, 0, []);
        yield return ([2], 3, 1, [2]);
    }
}