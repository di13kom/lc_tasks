namespace LeetCode.Problems._944;

public class Solution
{
    public int MinDeletionSize(string[] strs)
    {
        int retVal = 0;
        var lengthWord = strs[0].Length;
        var lengthArrayStrings = strs.Length;

        for (int i = 0; i < lengthWord; i++)
        {
            for (int j = 1; j < lengthArrayStrings; j++)
            {
                if (strs[j][i] < strs[j - 1][i])
                {
                    retVal++;
                    break;
                }
            }
        }
        return retVal;
    }
}