namespace LeetCode.Problems._119;

public class Solution
{
    int TotalRows;
    public IList<int> GetRow(int rowIndex)
    {
        TotalRows = rowIndex;

        return Traverse(1, new List<int>(new int[] { 1 }));

    }


    private IList<int> Traverse(int curLevel, IList<int> parentArray)
    {
        if (curLevel > TotalRows)
            return parentArray;

        parentArray.Add(0);
        int prevLeft = 0;
        int leftUp;
        int rightUp;

        for (int i = 0; i <= curLevel; i++)
        {
            if (prevLeft == 0)
                leftUp = i - 1 >= 0 ? parentArray[i - 1] : 0;
            else
                leftUp = prevLeft;
            rightUp = i <= parentArray.Count - 1 ? parentArray[i] : 0;

            prevLeft = rightUp;

            parentArray[i] = leftUp + rightUp;
        }

        return Traverse(curLevel + 1, parentArray);
    }
}