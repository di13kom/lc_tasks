namespace LeetCode.Problems._2106;

public class Solution
{
    public int MaxTotalFruits(int[][] fruits, int startPos, int k)
    {
        var length = fruits.Length;
        int retVal = 0;
        int startSum = 0;
        bool IsAligned;


        if (fruits.Length == 1)
        {
            return Math.Abs(fruits[0][0] - startPos) > k ? 0 : fruits[0][1];
        }
        int pos = BinarySearchIdxInsert(fruits, startPos);//Align to nearest right node,if not exists

        if (pos < length && fruits[pos][0] == startPos)
        {
            startSum = fruits[pos][1];
            IsAligned = true;
        }
        else
        {
            IsAligned = false;
        }
        List<(int, int)> leftList = [];
        List<(int, int)> rightList = [];
        if (pos > 0)
        {
            leftList = MoveToLeft(fruits, pos - 1, k - (startPos - fruits[pos - 1][0]));
            retVal = Math.Max(retVal, startSum + leftList.LastOrDefault().Item2);
        }

        if (pos < length)
        {
            if (pos != length - 1 || !IsAligned)
            {
                rightList = MoveToRight(fruits, IsAligned ? pos + 1 : pos, IsAligned ? k - (fruits[pos + 1][0] - startPos) : k - (fruits[pos][0] - startPos));
                retVal = Math.Max(retVal, startSum + rightList.LastOrDefault().Item2);
            }
        }

        retVal = Math.Max(retVal, startSum + TryMergeLists(leftList, rightList, startPos, k));

        return retVal;
    }

    private int TryMergeLists(List<(int, int)> leftList, List<(int, int)> rightList, int startPos, int k)
    {
        int retVal = 0;
        int curValue = -1;
        int prevJ = rightList.Count - 1;

        for (int i = 0; i < leftList.Count; i++)
        {
            for (int j = prevJ; j >= 0; j--)
            {
                if ((rightList[j].Item1 - startPos + (startPos - leftList[i].Item1) * 2) > k)
                    continue;
                curValue = leftList[i].Item2 + rightList[j].Item2;
                prevJ = j;
                break;
            }
            retVal = Math.Max(retVal, curValue);
        }

        curValue = -1;
        prevJ = leftList.Count - 1;
        for (int i = 0; i < rightList.Count; i++)
        {
            for (int j = prevJ; j >= 0; j--)
            {
                if (((rightList[i].Item1 - startPos) * 2 + (startPos - leftList[j].Item1)) > k)
                    continue;
                curValue = rightList[i].Item2 + leftList[j].Item2;
                prevJ = j;
                break;
            }
            retVal = Math.Max(retVal, curValue);
        }

        return retVal;
    }

    private List<(int, int)> MoveToLeft(int[][] fruits, int startPos, int k)
    {
        List<(int, int)> leftSums = [];
        int leftSteps = startPos;
        while (leftSteps >= 0 && fruits[leftSteps][0] >= (fruits[startPos][0] - k))
        {
            leftSums.Add((fruits[leftSteps][0], leftSums.LastOrDefault().Item2 + fruits[leftSteps][1]));
            leftSteps--;
        }

        return leftSums;
    }
    private List<(int, int)> MoveToRight(int[][] fruits, int startPos, int k)
    {
        List<(int, int)> rightSums = [];
        int rightSteps = startPos;
        while (rightSteps < fruits.Length && fruits[rightSteps][0] <= (fruits[startPos][0] + k))
        {
            rightSums.Add((fruits[rightSteps][0], rightSums.LastOrDefault().Item2 + fruits[rightSteps][1]));
            rightSteps++;
        }

        return rightSums;
    }

    int BinarySearchIdxInsert(int[][] array, int targetValue)
    {
        if (array[0][0] == targetValue)
            return 0;
        if (array.Length <= 1)
        {
            return array[0][0] >= targetValue ? 0 : 1;
        }

        var middleIndex = array.Length / 2;
        if (array[middleIndex][0] <= targetValue)
        {
            return middleIndex + BinarySearchIdxInsert(array[middleIndex..], targetValue);
        }
        else
        {
            return BinarySearchIdxInsert(array[0..middleIndex], targetValue);
        }
    }
}