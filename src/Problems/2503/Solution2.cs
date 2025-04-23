using System.Diagnostics;

namespace LeetCode.Problems._2503;

public class Solution2
{
    private readonly HashSet<Point> _set = [];
    List<Point> terminateQueue = [new Point(0, 0)];
    uint totalInterations = 0;
    int rows = 0;
    int columns = 0;
    public int[] MaxPoints(int[][] grid, int[] queries)
    {
        rows = grid.Length;
        columns = grid[0].Length;
        int[] retVal = new int[queries.Length];
        //Dictionary<int, uint> sortedQueries = queries.Order().Distinct().ToDictionary(x => x, x => 0u);
        int prevValue = 0;
        foreach ((int query, int index) in queries.Select((query, index) => (query, index)).OrderBy(e => e.query))
        {
            var lst = terminateQueue;
            terminateQueue = [];
            retVal[index] = prevValue;
            foreach (var curPoint in lst)
            {
                if (!_set.Contains(curPoint))
                    retVal[index] += FindNextMove(grid, curPoint, query);
            }
            prevValue = retVal[index];
        }

        Debug.WriteLine($"Total iterations - {totalInterations}");
        return retVal.ToArray();
    }

    private int FindNextMove(int[][] grid, Point position, int query)
    {
        totalInterations++;
        int retVal = 0;
        if (position.X < 0 || position.X >= rows || position.Y < 0 || position.Y >= columns || _set.Contains(position))
        {
            _set.Add(position);
            return 0;
        }
        if (query <= grid[position.X][position.Y])
        {
            terminateQueue.Add(position);
            return 0;
        }
        else if (query > grid[position.X][position.Y] && !_set.Contains(position))
        {
            retVal++;
            _set.Add(position);
            //Debug.WriteLine($"Set with{position.X}-{position.Y}, and values query{query} - cell{grid[position.X][position.Y]}");
        }
        var point1 = new Point(position.X, position.Y - 1);
        var point2 = new Point(position.X, position.Y + 1);
        var point3 = new Point(position.X - 1, position.Y);
        var point4 = new Point(position.X + 1, position.Y);

        return retVal
                    + (position.Y > 0 && !_set.Contains(point1) ? FindNextMove(grid, point1, query) : 0)
                    + (position.Y < columns - 1 && !_set.Contains(point2) ? FindNextMove(grid, point2, query) : 0)
                    + (position.X > 0 && !_set.Contains(point3) ? FindNextMove(grid, point3, query) : 0)
                    + (position.X < rows - 1 && !_set.Contains(point4) ? FindNextMove(grid, point4, query) : 0);
    }

    private record Point(int X, int Y) : IEquatable<Point>;
}
