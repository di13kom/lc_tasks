namespace LeetCode.Problems._1287;

public class Solution
{
    public int FindSpecialInteger(int[] arr)
    {
        int retVal = -1;
        int curCounter = 1;
        int counter = -1;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] != arr[i - 1])
            {
                if (curCounter > counter)
                {
                    counter = curCounter;
                    retVal = arr[i - 1];
                }
                curCounter= 0;
            }
            curCounter++;
        }
                if (curCounter > counter)
                {
                    counter = curCounter;
                    retVal = arr.Last();
                }

        return retVal;
    }
}