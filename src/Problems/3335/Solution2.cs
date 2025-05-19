using System;
using System.Text;

namespace LeetCode.Problems._3335;
public class Solution2
{
    public int LengthAfterTransformations(string s, int t)
    {
        int retVal = 0;
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < t; i++)
        {
            foreach (var item in s)
            {
                if (item == 'z')
                    sb.Append("ab");
                else
                {
                    char c = (char)(item + 1);
                    sb.Append(c);
                }
            }
            s = sb.ToString();
            sb.Clear();
            Console.WriteLine(s);
        }


        retVal = (int)(s.Length % (Math.Pow(10, 9) + 7));

        return retVal;
    }
}
