using LeetCode.Problems._26;

namespace ProblemsUnitTests._26;

public class Problem26UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, int expected, int[] expectedArray) td)
    {
        Assert.Multiple(() =>
        {
            Assert.That(new Solution().RemoveDuplicates(td.input), Is.EqualTo(td.expected));
            Assert.That(td.input.Take(td.expected), Is.EqualTo(td.expectedArray));
        });
    }

    private static IEnumerable<(int[], int, int[])> GetTestCaseDatas()
    {
        yield return ([1, 1, 2], 2, [1, 2]);
        yield return ([0, 0, 1, 1, 1, 2, 2, 3, 3, 4], 5, [0, 1, 2, 3, 4]);
    }
}