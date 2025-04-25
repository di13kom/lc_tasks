using System;

namespace _1._2140;

class Solution_leetCode
{
    public long MostPoints(int[][] questions)
    {
        long[] dp = new long[1000000];
        for (int i = questions.Length - 1; i >= 0; i--)
        {
            dp[i] = Math.Max(questions[i][0] + dp[i + questions[i][1] + 1], dp[i + 1]);
        }
        return dp[0];
    }

    public long MostPoints0(int[][] questions) {
        int n = questions.Length;
        // dp[i] represents the maximum points starting from index i
        long[] dp = new long[n + 1]; // +1 to handle jumps beyond n
        
        // Base case: dp[n] = 0 (already initialized as 0 in C#)
        
        // Fill dp from right to left
        for (int i = n - 1; i >= 0; i--) {
            int points = questions[i][0];
            int jump = questions[i][1];
            // Next index after solving question i
            int nextQuestion = Math.Min(n, i + jump + 1);
            // dp[i] = max(solve, skip)
            // Solve: points + dp[nextQuestion]
            // Skip: dp[i + 1]
            dp[i] = Math.Max(points + dp[nextQuestion], dp[i + 1]);
        }
        
        return dp[0];
    }
}