namespace LeetCode.Problems._58;

public class Solution
{
    public int LengthOfLastWord(string s)
    {
        int retVal = 0;
        bool IsWordStart = false;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] != ' ')
            {
                if (!IsWordStart)
                {
                    IsWordStart = true;
                    retVal++;
                }
                else
                {
                    retVal++;
                }
            }
            else if (IsWordStart)
            {
                break;
            }
        }

        return retVal;
    }
}