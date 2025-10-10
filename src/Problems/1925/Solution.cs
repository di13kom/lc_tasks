
namespace LeetCode.Problems._1925;

public class Solution
{
    public int CountTriples(int n)
    {
        int retVal = 0;

        for (int i = n; i > 0; i--)
        {
            var c = i * i;
            for (int j = i - 1; j > 0; j--)
            {
                for (int k = i - 1; k > 0; k--)
                {
                    var mlt = k * k + j * j;
                    if (mlt < c)
                        break;
                    if (mlt == c)
                        retVal++;
                }
            }

        }


        return retVal;
    }
}