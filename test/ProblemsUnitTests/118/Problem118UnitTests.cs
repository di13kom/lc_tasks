using LeetCode.Problems._118;

namespace ProblemsUnitTests._118;

public class Problem118UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(1, new[] { 1 })]
    [TestCase(5, new[] { 1, 1, 1, 1, 2, 1, 1, 3, 3, 1, 1, 4, 6, 4, 1 })]
    public void Test1(int input, int[] expArray)
    {
        List<List<int>> expected = [];
        int SkipSum = 0;
        for (int i = 0; i < input; i++)
        {
            expected.Add(new List<int>(expArray.Skip(SkipSum).Take(i + 1)));
            SkipSum += i + 1;
        }
        Assert.That(new Solution().Generate(input), Is.EqualTo(expected));
    }
}
