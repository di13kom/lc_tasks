using System;

namespace LeetCode.Problems._2140;

public class Solution
{
    long[] Points;
    public long MostPoints(int[][] questions)
    {
        Points = new long[questions.Length];

        if (questions.Length == 1)
            return questions[0][0];

        return MostPointsNode(questions, 0);
    }

    private long MostPointsNode(int[][] questions, int position)
    {
        if (position >= questions.Length)
            return 0;

        long solveResult;
        long skipResult;
        if (Points[position] > 0)
        {
            solveResult = Points[position];
            skipResult = Points[position];
        }
        else
        {

            int nextSolveIdx = position + questions[position][1] + 1;
            int nextSkipIdx = position + 1;

            solveResult = questions[position][0] + MostPointsNode(questions, nextSolveIdx);
            skipResult = 0 + MostPointsNode(questions, nextSkipIdx);

            Points[position] = Math.Max(solveResult, skipResult);
        }

        return Math.Max(solveResult, skipResult);
    }
}