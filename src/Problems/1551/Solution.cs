namespace LeetCode.Problems._1551;

public class Solution
{
    public int MinOperations(int n)
    {
        int retVal = 0;
        int[] array = new int[n];
        int sum = 0;
        int idx = 0;
        for (int i = 0; i < n; i++)
        {
            var elem = GetArrayValueByIndex(i);
            sum += elem;
            array[i] = elem;
        }
        var target = sum / n;

        while (idx < n / 2)
        {
            retVal += array[n - 1 - idx] - target;
            idx++;
        }


        return retVal;
    }

    private int GetArrayValueByIndex(int idx) => (2 * idx) + 1;

}