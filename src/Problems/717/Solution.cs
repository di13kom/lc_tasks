using System.Net.Http.Headers;

namespace LeetCode.Problems._717;

public class Solution
{
    public bool IsOneBitCharacter(int[] bits)
    {
        var length = bits.Length;
        bool retVal = bits[0] == 0;
        bool IsPrevWordEnded = bits[0] == 0;

        for (int i = 1; i < length; i++)
        {
            if (bits[i] == 0)
            {
                if (IsPrevWordEnded)
                    retVal = true;
                else
                {
                    retVal = false;
                    IsPrevWordEnded = true;
                }
            }
            else
            {
                IsPrevWordEnded = IsPrevWordEnded == false;
            }

        }

        return retVal;
    }
}