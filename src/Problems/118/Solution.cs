
namespace LeetCode.Problems._118;

public class Solution
{
    IList<IList<int>> retVal;
    int TotalRows;
    public IList<IList<int>> Generate(int numRows)
    {
        TotalRows = numRows;

        retVal = [];
        /*
        for (int i = 1; i <= numRows; i++)
        {
            retVal.Add(new List<int>(new int[i]));
        }
        */
        retVal.Add(new List<int>(new int[] { 1 }));
        Traverse(1);

        return retVal;
    }

    private void Traverse(int curLevel)
    {
        if (curLevel == TotalRows)
            return;

        retVal.Add(new List<int>(new int[curLevel + 1]));

        for (int i = 0; i <= curLevel; i++)
        {
            var leftUp = i - 1 >= 0 ? retVal[curLevel - 1][i - 1] : 0;
            var rightUp = i <= retVal[curLevel - 1].Count - 1 ? retVal[curLevel - 1][i] : 0;
            retVal[curLevel][i] = leftUp + rightUp;
        }

        Traverse(curLevel + 1);
    }
}