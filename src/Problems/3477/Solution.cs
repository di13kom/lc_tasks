namespace LeetCode.Problems._3477;

public class Solution
{
    const int FilledBasket = 1;
    const int EmptyBasket = 0;
    public int NumOfUnplacedFruits(int[] fruits, int[] baskets)
    {
        bool IsFruitOccupiedBasket;
        int retVal = 0;
        var basketLength = baskets.Length;
        int[] usedBaskets = new int[basketLength];

        for (int i = 0; i < fruits.Length; i++)
        {
            IsFruitOccupiedBasket = false;
            for (int j = 0; j < basketLength; j++)
            {
                if (usedBaskets[j] != EmptyBasket)
                    continue;

                if (fruits[i] <= baskets[j])
                {
                    usedBaskets[j] = FilledBasket;
                    IsFruitOccupiedBasket = true;
                    break;
                }
            }
            retVal = IsFruitOccupiedBasket ? retVal : retVal + 1;
        }


        return retVal;
    }
}