namespace LeetCode.Problems._898;

public class Solution
{
    public int SubarrayBitwiseORs(int[] arr)
    {
        HashSet<int> intsSet = [];
        int allOrSum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            allOrSum |= arr[i];
        }
        if (allOrSum == 0)
            return 1;

        for (int i = 0; i < arr.Length; i++)
        {
            if (i > 0 && arr[i] == arr[i - 1])//x|x=x  - same value, all subquence will be the same.
                continue;
            var curValue = arr[i];
            intsSet.Add(arr[i]);
            for (int j = i + 1; j < arr.Length; j++)
            {
                curValue |= arr[j];
                intsSet.Add(curValue);
                if (curValue == allOrSum)//encountered allOrSum value, there is no way up this value.
                    break;
            }
        }


        return intsSet.Count;
    }
}