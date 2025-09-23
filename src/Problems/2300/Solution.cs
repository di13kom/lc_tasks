namespace LeetCode.Problems._2300;

public class Solution
{
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
    {
        var length = spells.Length;
        var potionsLength = potions.Length;
        int[] retVal = new int[length];

        Array.Sort(potions);
        for (int i = 0; i < length; i++)
        {
            //Crucial
            if (i > 0 && spells[i] == spells[i - 1])
            {
                retVal[i] = retVal[i - 1];
                continue;
            }
            double targetPotion = Math.Ceiling(success * 1d / spells[i]);
            if (targetPotion > int.MaxValue || targetPotion > potions[potionsLength - 1])
            {
                retVal[i] = 0;
                continue;
            }

            var idx = Array.BinarySearch(potions, (int)targetPotion);
            if (idx < 0)
            {
                idx = ~idx;
            }
            //On positive idx search first next value
            // else if (idx < potionsLength && (long)potions[idx] * spells[i] < success)
            // {
            //     while (idx < potionsLength && (long)potions[idx] * spells[i] < success)
            //     {
            //         idx++;
            //     }
            // }
            //Possible to non first occurence of the int.
            else if (idx > 0 && potions[idx] == potions[idx - 1])
            {
                while (idx > 0 && potions[idx] == potions[idx - 1])
                {
                    idx--;
                }
            }
            retVal[i] = potionsLength - idx;
        }


        return retVal;
    }
}