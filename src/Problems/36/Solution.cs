using System.Diagnostics;
using System.Net.Http.Headers;

namespace LeetCode.Problems._36;

public class Solution
{
    private const char EmptyCell = '.';
    private const int BoxLengthWidth = 3;
    private const int BoxesRowsColumns = 3;
    public bool IsValidSudoku(char[][] board)
    {
        if (!IsRowsValid(board) || !IsColumnsValid(board) || !IsBoxesValid(board))
        {
            return false;
        }


        return true;
    }

    private bool IsBoxesValid(char[][] board)
    {
        HashSet<char> charsInBox = [];
        int boxNum = 1;
        for (int boxNumberInRow = 0; boxNumberInRow < BoxesRowsColumns; boxNumberInRow++)
        {
            for (int boxNumberInColumn = 0; boxNumberInColumn < BoxesRowsColumns; boxNumberInColumn++)
            {
                Debug.WriteLine($"Box #{boxNum++}");
                for (int cellNumberInRow = 0; cellNumberInRow < BoxLengthWidth; cellNumberInRow++)
                {
                    for (int cellNumberInColumn = 0; cellNumberInColumn < BoxLengthWidth; cellNumberInColumn++)
                    {
                        var xCoor = cellNumberInRow + BoxLengthWidth * boxNumberInRow;
                        var yCoor = cellNumberInColumn + BoxLengthWidth * boxNumberInColumn;
                        Debug.WriteLine($"Current coor:x{xCoor}, y:{yCoor}");
                        char curElem = board[xCoor][yCoor];
                        if (curElem != EmptyCell && !charsInBox.Add(curElem))
                        {
                            return false;
                        }
                    }
                }
                charsInBox.Clear();
            }
        }
        return true;
    }

    private bool IsColumnsValid(char[][] board)
    {
        HashSet<char> charsInColumn = [];
        for (int j = 0; j < board[0].Length; j++)
        {
            for (int i = 0; i < board.Length; i++)
            {
                if (board[i][j] != EmptyCell && !charsInColumn.Add(board[i][j]))
                {
                    return false;
                }
            }
            charsInColumn.Clear();
        }
        return true;
    }

    private bool IsRowsValid(char[][] board)
    {
        HashSet<char> charsInRow = [];
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[0].Length; j++)
            {
                if (board[i][j] != EmptyCell && !charsInRow.Add(board[i][j]))
                {
                    return false;
                }
            }
            charsInRow.Clear();
        }
        return true;
    }
}