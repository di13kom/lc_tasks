using NUnit.Framework;
using LeetCode.Problems._2200;

namespace ProblemsUnitTests._2200;

public class Problem2200UnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void SolutionTests((int[] input, int key, int k, IList<int> expected) td)
    {
        Assert.That(new Solution().FindKDistantIndices(td.input, td.key, td.k), Is.EqualTo(td.expected));
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Solution1Tests((int[] input, int key, int k, IList<int> expected) td)
    {
        Assert.That(new Solution1().FindKDistantIndices(td.input, td.key, td.k), Is.EqualTo(td.expected));
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Solution2Tests((int[] input, int key, int k, IList<int> expected) td)
    {
        Assert.That(new Solution2().FindKDistantIndices(td.input, td.key, td.k), Is.EqualTo(td.expected));
    }

    [TestCaseSource(nameof(GetTestCaseDatas))]
    public void Solution3Tests((int[] input, int key, int k, IList<int> expected) td)
    {
        Assert.That(new Solution3().FindKDistantIndices(td.input, td.key, td.k), Is.EqualTo(td.expected));
    }

    private static IEnumerable<(int[], int, int, IList<int>)> GetTestCaseDatas()
    {
        yield return ([3, 4, 9, 1, 3, 9, 5], 9, 1, [1, 2, 3, 4, 5, 6]);
        yield return ([2, 2, 2, 2, 2], 2, 2, [0, 1, 2, 3, 4]);
        yield return ([828, 549, 114, 253, 451, 252, 601, 531, 193, 148, 768, 894, 437, 74, 925, 825, 667, 429, 894, 476, 462, 192, 948, 143, 796, 771, 133, 589, 637, 588, 54, 925, 383, 32, 253, 288, 899, 287, 75, 590, 871]
        , 148, 1, [8, 9, 10]);
        yield return ([734, 228, 636, 204, 552, 732, 686, 461, 973, 874, 90, 537, 939, 986, 855, 387, 344, 939, 552, 389, 116, 93, 545, 805, 572, 306, 157, 899, 276, 479, 337, 219, 936, 416, 457, 612, 795, 221, 51, 363, 667, 112, 686, 21, 416, 264, 942, 2, 127, 47, 151, 277, 603, 842, 586, 630, 508, 147, 866, 434, 973, 216, 656, 413, 504, 360, 990, 228, 22, 368, 660, 945, 99, 685, 28, 725, 673, 545, 918, 733, 158, 254, 207, 742, 705, 432, 771, 578, 549, 228, 766, 998, 782, 757, 561, 444, 426, 625, 706, 946], 939, 34,
        [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51]);
    }
}
