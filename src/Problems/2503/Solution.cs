using System.Diagnostics;

namespace LeetCode.Problems._2503;

public class Solution
{
    private readonly HashSet<Point> _set = [];
    PriorityQueue<Point, int> terminateQueue = new();
    uint totalInterations = 0;
    int rows = 0;
    int columns = 0;
    public int[] MaxPoints(int[][] grid, int[] queries)
    {
        rows = grid.Length;
        columns = grid[0].Length;
        int[] retVal = new int[queries.Length];
        terminateQueue.Enqueue(new Point(0, 0), grid[0][0]);
        int prevValue = 0;
        foreach ((int query, int index) in queries.Select((query, index) => (query, index)).OrderBy(e => e.query))
        {
            retVal[index] = prevValue;
            while (terminateQueue.TryPeek(out var point, out var priority))
            {
                if (priority < query)
                {
                    if (!_set.Contains(point))
                        retVal[index] += FindNextMove(grid, point, query);

                    terminateQueue.Dequeue();
                }
                else
                {
                    break;
                }
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
            terminateQueue.Enqueue(position, grid[position.X][position.Y]);
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