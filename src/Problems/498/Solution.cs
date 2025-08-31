namespace LeetCode.Problems._498;

public class Solution
{
    public int[] FindDiagonalOrder(int[][] mat)
    {
        int height = mat.Length;
        int width = mat[0].Length;
        int curX = 0;
        int curY = 0;
        int iter = 0;
        //Move direction
        bool isMoveUp = true;

        int[] retVal = new int[height * width];

        if (height == 1)
            return mat[0];


        while (iter < height * width)
        {
            retVal[iter++] = mat[curY][curX];

            if (curX >= width - 1 && isMoveUp)//Right width bound, get down.
            {
                curY += 1;
                isMoveUp = !isMoveUp;
                continue;
            }
            else if (curY <= 0 && isMoveUp)//Lower cartesian(array upper bound) height bound, get right.
            {
                curX += 1;
                isMoveUp = !isMoveUp;
                continue;
            }
            else if (curY >= height - 1 && !isMoveUp)//Upper cartesian(array lower bound) height bound, get right.
            {
                curX += 1;
                isMoveUp = !isMoveUp;
                continue;
            }
            else if (curX <= 0 && !isMoveUp)//Left width bound, get right.
            {
                curY += 1;
                isMoveUp = !isMoveUp;
                continue;
            }

            if (isMoveUp)
            {
                curY -= 1;
                curX += 1;
            }
            else
            {
                curY += 1;
                curX -= 1;
            }
        }

        return retVal;
    }
}