using System.Diagnostics;
using System.Linq.Expressions;

namespace LeetCode.Problems._2503;

public class Solution3
{
    private readonly HashSet<Point> _set = [];
    uint totalInterations = 0;
    public int[] MaxPoints(int[][] grid, int[] queries)
    {
        List<int> retVal = [];
        foreach (var item in queries)
        {
            retVal.Add(FindNextMove(grid, new Point(0, 0), item));
            _set.Clear();
        }


        Debug.WriteLine($"Total iterations - {totalInterations}");
        return retVal.ToArray();
    }

    private int FindNextMove(int[][] grid, Point position, int query)
    {
        int retVal = 0;
        if (position.X < 0 || position.X >= grid.Length || position.Y < 0 || position.Y >= grid[0].Length)
        {
            return 0;
        }
        totalInterations++;
        if (query <= grid[position.X][position.Y] || _set.Contains(position))
        {
            return 0;
        }
        else if (query > grid[position.X][position.Y] && !_set.Contains(position))
        {
            retVal++;
            _set.Add(position);
            //Debug.WriteLine($"Set with{position.X}-{position.Y}, and values query{query} - cell{grid[position.X][position.Y]}");
        }

        return retVal
                    + FindNextMove(grid, new Point(position.X, position.Y - 1), query)
                    + FindNextMove(grid, new Point(position.X, position.Y + 1), query)
                    + FindNextMove(grid, new Point(position.X - 1, position.Y), query)
                    + FindNextMove(grid, new Point(position.X + 1, position.Y), query);
    }

    private record Point(int X, int Y) : IEquatable<Point>
    {
    }
}
