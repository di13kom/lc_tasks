
namespace LeetCode.Problems._165;

public class Solution
{
    const char VersonSeparator = '.';
    const char ZeroChar = '0';
    public int CompareVersion(string version1, string version2)
    {
        int retVal;

        var length1 = version1.IndexOf(VersonSeparator);
        var length2 = version2.IndexOf(VersonSeparator);

        int curVersion1 = GetVersion(length1 > 0 ? version1.AsSpan(0, length1) : version1.AsSpan(0));
        int curVersion2 = GetVersion(length2 > 0 ? version2.AsSpan(0, length2) : version2.AsSpan(0));
        if (curVersion1 > curVersion2)
        {
            return 1;
        }
        else if (curVersion1 < curVersion2)
        {
            return -1;
        }
        else if (length1 == -1 && length2 == -1)
        {
            return 0;
        }
        else if (length1 == -1)
        {
            version1 = "0";
        }
        else if (length2 == -1)
        {
            version2 = "0";
        }

        retVal = CompareVersion(version1[(length1 + 1)..], version2[(length2 + 1)..]);

        return retVal;
    }

    private int GetVersion(ReadOnlySpan<char> v)
    {
        int retVal = 0;
        bool nonZeroHeadSymbolPassed = false;
        foreach (var item in v)
        {
            int curVal = item - ZeroChar;
            nonZeroHeadSymbolPassed = curVal > 0 || nonZeroHeadSymbolPassed;
            if (nonZeroHeadSymbolPassed)
            {
                retVal *= 10;
                retVal += curVal;
            }
        }

        return retVal;
    }
}