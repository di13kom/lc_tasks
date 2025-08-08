using LeetCode.Problems._599;

namespace ProblemsUnitTests._599;

public class Problem599UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((string[] input0, string[] input1, string[] expected) td)
    {
        Assert.That(new Solution().FindRestaurant(td.input0, td.input1), Is.EquivalentTo(td.expected));
    }
    private static IEnumerable<(string[], string[], string[])> GetTestCaseDatas()
    {
        yield return (["Shogun", "Tapioca Express", "Burger King", "KFC"],
                        ["Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun"],
                        ["Shogun"]);

        yield return (["Shogun", "Tapioca Express", "Burger King", "KFC"],
                        ["KFC", "Shogun", "Burger King"],
                        ["Shogun"]);
        yield return (["happy", "sad", "good"],
                        ["sad", "happy", "good"],
                        ["sad", "happy"]);
        yield return (["Shogun", "Tapioca Express", "Burger King", "KFC"],
                        ["KFC", "Burger King", "Tapioca Express", "Shogun"],
                        ["KFC", "Burger King", "Tapioca Express", "Shogun"]);
        yield return (["S", "TEXP", "BK", "KFC"],
                        ["KFC", "BK", "S"],
                        ["S"]);
    }
}
