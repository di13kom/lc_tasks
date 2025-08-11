namespace LeetCode.Problems._2038;

public class Solution
{
    public bool WinnerOfGame(string colors)
    {
        const char aliceLetter = 'A';
        const char bobLetter = 'B';
        const byte sequenceSteps = 3;
        int aliceStepsCount = 0;
        int bobStepsCount = 0;
        char lastLetter = '_';
        char everLastLetter = '$';

        for (int i = 0; i < colors.Length; i++)
        {
            if (colors[i] == lastLetter && lastLetter == everLastLetter)
            {
                if (colors[i] == aliceLetter)
                    aliceStepsCount++;
                else
                    bobStepsCount++;
            }
            everLastLetter = lastLetter;
            lastLetter = colors[i];
        }
        return aliceStepsCount > bobStepsCount;
    }
}