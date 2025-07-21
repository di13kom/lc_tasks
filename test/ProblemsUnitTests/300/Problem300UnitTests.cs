using LeetCode.Problems._300;

namespace ProblemsUnitTests._300;

public class Problem300UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTest((int[] input, int expected) td)
    {
        Assert.That(new Solution().LengthOfLIS(td.input), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int)> GetTestCaseDatas()
    {
        yield return ([10, 9, 2, 5, 3, 7, 101, 18], 4);//2,3,5,7,9,10,18,101
        yield return ([0, 1, 0, 3, 2, 3], 4);//0,0,1,2,3,3
        yield return ([7, 7, 7, 7, 7, 7, 7], 1);
        yield return ([-86, -60], 2);
        yield return ( [ -35, 27, -71, -24, -13, -13, 15, 10, 45, -75, -53, -75, 29, -39, -56, 44, 5, -39, -16, -18, 35, 5, -34, 47,
                        -62, -56, -59, -72, -40, -70, -68, -25, -9, -11, 37, -46, -35, -18, 9, -54, 3, 0, 25, -34, -21, -73, -46,
                        -26, -43, -18], 9);
        yield return ( [ 98, 42, 61, 11, -24, -47, 83, -9, 85, 60, -45, -25, 14, 75, 73, -16, -22, -27, -7, -17, 16, 54, 37, 81, 87,
                            38, 18, -17, 100, -42, 86, 45, -40, 60, 92, 39, 83, 0, 65, 96, 85, -21, 97, 23, -20, -34, 75, 53, 30, 37, -4,
                            6, 29, -39, 37, -42, -18, 69, 8, -33, -25, 10, -20, 74, -47, 95, 66, -32, 84, -3, 25, 12, -25, 60, 51, 93,
                            81, -10, -28, -34, -22, 64, -45, -18, -31, 91, 39, -10, 59, -31, 52, 12, -39, 58, -22, 81, 69, 88, 0, 95
                        ], 17);
    }
}