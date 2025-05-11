using LeetCode.Problems._1128;

namespace ProblemsUnitTests._1128;

public class Promblem1128UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(new int[] { 1, 2, 2, 1, 3, 4, 5, 6 }, 1)]
    [TestCase(new int[] { 1, 2, 1, 2, 1, 1, 1, 2, 2, 2 }, 3)]
    [TestCase(new int[] { 1, 1, 2, 2, 1, 1, 1, 2, 1, 2, 1, 1 }, 4)]
    public void Test(int[] input, long expected)
    {
        List<int[]> ints = [];
        int evenValue = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (i % 2 == 0)
            {
                evenValue = input[i];
            }
            else
            {
                ints.Add([evenValue, input[i]]);
            }

        }
        Assert.That(new Solution().NumEquivDominoPairs(ints.ToArray()), Is.EqualTo(expected));
    }
}
