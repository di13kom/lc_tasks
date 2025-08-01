using System.Diagnostics;

namespace LeetCode.Problems._48;

public class Solution
{
    public void Rotate(int[][] matrix)
    {
        var length = matrix.Length;
        var vl = length - 1;

        int[][] newMatrix = new int[matrix.Length][];
        for (int i = 0; i < length; i++)
        {
            newMatrix[i] = new int[length];
            Array.Copy(matrix[i], newMatrix[i], length);
        }

        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length; j++)
            {
                // Debug.Write($"[{i}][{j}]|");
                var tmp = newMatrix[i][j];


                var i0 = i + vl;
                // Debug.Write($"[{j}][{i0}]|");
                matrix[j][i0] = tmp;

                // Debug.WriteLine("===");
            }
            vl -= 2;
        }
    }
}