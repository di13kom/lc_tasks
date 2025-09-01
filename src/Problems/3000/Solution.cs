namespace LeetCode.Problems._3000;

public class Solution
{
    public int AreaOfMaxDiagonal(int[][] dimensions)
    {
        Tuple<double, int> retVal = Tuple.Create(0d, 0);
        for (int i = 0; i < dimensions.Length; i++)
        {
            var diagonalValue = Math.Sqrt(dimensions[i][0] * dimensions[i][0] + dimensions[i][1] * dimensions[i][1]);
            var squareValue = dimensions[i][0] * dimensions[i][1];

            if ((diagonalValue == retVal.Item1 && squareValue > retVal.Item2) || diagonalValue > retVal.Item1)
            {
                retVal = Tuple.Create(diagonalValue, squareValue);
            }
        }

        return retVal.Item2;
    }
}