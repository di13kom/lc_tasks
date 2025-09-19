using System.Drawing;

namespace LeetCode.Problems._812;

public class Solution
{
    public double LargestTriangleArea(int[][] points)
    {
        int length = points.Length;
        double retVal = 0.0d;
        for (int i = 0; i < length - 2; i++)
        {
            for (int j = i + 1; j < length - 1; j++)
            {
                for (int k = j + 1; k < length; k++)
                {
                    double a = GetSide(points[i], points[j]);
                    double b = GetSide(points[j], points[k]);
                    double c = GetSide(points[i], points[k]);
                    if (IsValidTraingle(a, b, c))
                    {
                        var sqr = GetAreaBySides(a, b, c);
                        if (sqr > retVal)
                        {
                            //Console.WriteLine($"new retVal:{retVal}");
                            retVal = sqr;
                        }
                    }
                }
            }
        }

        return Math.Round(retVal, 5);
    }

    private double GetSide(int[] x, int[] y)
    {
        var a = Math.Abs(x[0] - y[0]);
        var b = Math.Abs(x[1] - y[1]);
        return GetSideByPythagoreanTheorem(a, b);
    }

    private double GetAreaBySides(double a, double b, double c)
    {
        var p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    private double GetSideByPythagoreanTheorem(int x, int y)
    {
        return Math.Sqrt(x * x + y * y);
    }

    //Valid Triangle means if you added length of any 2 side it will be greater than 3rd side length
    private bool IsValidTraingle(double x, double y, double z)
    {
        return x + y > z && z + y > x;
    }
}