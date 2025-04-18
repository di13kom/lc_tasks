using System.Diagnostics;

namespace LeetCode.Problems._22;

public class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        IList<string> retVal = new List<string>();
        int lngth = n * 2;
        int startLeftIdx = n - 1;
        int startRightIdx = n;
        char[] targetArray = new char[lngth];
        for (int i = 0, j = 1; i < n; i++, j++)
        {
                targetArray[i] = '(';
                targetArray[lngth - j] = ')';
        }
        retVal.Add(new string(targetArray));
        Console.WriteLine(retVal.Last());

        startLeftIdx++;
        do
        {
            Console.WriteLine("Round");
            var curRight = startRightIdx;
            char[] rightArray = new char[lngth];
            for (int i = 0; i < n - 1; i++)
            {
                SwapValues(targetArray, curRight, --curRight);//Move right bracket to Left
                var curLeft = startLeftIdx;
                retVal.Add(new string(targetArray));
                Console.WriteLine(retVal.Last());
                Array.Copy(targetArray, rightArray, lngth);
                for (int j = 0; j < n - 2; j++)
                {
                    SwapValues(rightArray, curLeft, ++curLeft);//Move left bracket to right
                    retVal.Add(new string(rightArray));
                    Console.WriteLine(retVal.Last());
                }
                Console.WriteLine("---");

            }
            Array.Copy(rightArray, targetArray, lngth);
            n -= 2;
        }
        while (n > 0);


        return retVal;
    }

    private void SwapValues(char[] arr, int idx0, int idx1)
    {
        arr[idx0] ^= arr[idx1];
        arr[idx1] ^= arr[idx0];
        arr[idx0] ^= arr[idx1];
    }
}
