namespace LeetCode.Problems._2438;

public class Solution
{
    const double moduloValue = 1E9 + 7;
    public int[] ProductQueries(int n, int[][] queries)
    {
        var length = queries.Length;
        int[] retVal = new int[length];
        var array = GetBinaryList(n);

        for (int i = 0; i < length; i++)
        {
            var idx0 = queries[i][0];
            var idx1 = queries[i][1];
            retVal[i] = 1;
            /*
            if (idx0 == 0)
            {
                retVal[i] = array[queries[i][1]].Value;
            }
            else if (idx0 == idx1)
            {

                retVal[i] = array[queries[i][1]].Key;
            }
            else
            {
                retVal[i] = array[queries[i][1]].Value / (array[queries[i][0] - 1].Value);
            }
            */
            for (int j = idx0; j <= idx1; j++)
            {
                retVal[i] = (int)((int)(retVal[i] % moduloValue * array[j].Key % moduloValue) % moduloValue);
            }

        }
        return retVal;
    }

    private List<KeyValuePair<int, int>> GetBinaryList(int n)
    {
        List<KeyValuePair<int, int>> retVal = [];
        int pow = 0;
        int curValue = n;
        do
        {
            if (curValue > 0 && (curValue & 1) == 1)
            {
                var vl = 1 << pow;
                var prev = retVal.Count == 0 ? 1 : retVal.Last().Value;
                retVal.Add(KeyValuePair.Create(1 << pow, (int)((vl % moduloValue * prev % moduloValue) % moduloValue)));
            }
            pow++;
            curValue >>= 1;

        } while (curValue > 0);


        return retVal;
    }
}