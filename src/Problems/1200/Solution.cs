using System.Globalization;

namespace LeetCode.Problems._1200;

public class Solution
{
    public IList<IList<int>> MinimumAbsDifference(int[] arr)
    {
        IList<IList<int>> retVal = [];

        Array.Sort(arr);

        retVal.Add([arr[0], arr[1]]);

        for (int i = 2; i < arr.Length; i++)
        {
            var diff = arr[i] - arr[i - 1];
            if (diff < retVal[0][1] - retVal[0][0])
            {
                retVal.Clear();
                retVal.Add([arr[i - 1], arr[i]]);
            }
            else if (diff == retVal[0][1] - retVal[0][0])
            {
                retVal.Add([arr[i - 1], arr[i]]);
            }
        }

        return retVal;
    }
}