namespace LeetCode.Problems._1346;

public class Solution
{
    public bool CheckIfExist(int[] arr)
    {
        bool retVal = false;
        var length = arr.Length;
        Dictionary<int, int> Ints = [];

        int idx;
        for (int i = 0; i < length; i++)
        {
            var vl = arr[i];
            var posVal = vl / 2;
            var negVal = -posVal;
            if (vl % 2 == 0)
            {
                //if (vl > 0 && (Ints.TryGetValue(posVal, out idx) || Ints.TryGetValue(negVal, out idx)))//20 / 2 = 10 || 20 / 2 = -10;
                //    return true;
                //else if (vl < 0 && Ints.TryGetValue(posVal, out idx))//-20 / 2 = -1
                //    return true;
                if (Ints.TryGetValue(posVal, out idx))//-20 / 2 = -1
                    return true;
            }
            if (Ints.TryGetValue(vl * 2, out idx))
            {
                return true;
            }

            Ints.TryAdd(vl, i);
        }

        return retVal;
    }
}
