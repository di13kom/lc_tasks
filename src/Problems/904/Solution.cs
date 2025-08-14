namespace LeetCode.Problems._904;

public class Solution
{
    private class FruitInfo
    {
        public FruitInfo(int amount, int number, int lastIndex)
        {
            Amount = amount;
            Number = number;
            LastIndex = lastIndex;
        }

        public int Amount { get; set; }
        public int Number { get; set; }
        public int LastIndex { get; set; }
    }
    public int TotalFruit(int[] fruits)
    {
        int retVal = 0;
        int length = fruits.Length;
        const int defaultValue = -1;
        FruitInfo basket0 = new FruitInfo(1, fruits[0], 0);
        FruitInfo basket1 = new FruitInfo(0, defaultValue, defaultValue);

        for (int i = 1; i < length; i++)
        {
            if (basket0.Number == fruits[i] || basket1.Number == fruits[i])
            {
                if (basket0.Number == fruits[i])
                {
                    basket0.Amount++;
                    basket0.LastIndex = i;
                }
                else
                {
                    basket1.Amount++;
                    basket1.LastIndex = i;
                }
            }
            else if (basket1.Number == defaultValue)
            {
                basket1.Number = fruits[i];
                basket1.Amount = 1;
                basket1.LastIndex = i;
            }
            else
            {
                retVal = Math.Max(retVal, basket0.Amount + basket1.Amount);

                if (basket0.LastIndex > basket1.LastIndex)
                {
                    basket0.Amount = basket0.LastIndex - basket1.LastIndex;

                    basket1.Amount = 1;
                    basket1.Number = fruits[i];
                    basket1.LastIndex = i;

                }
                else
                {
                    basket1.Amount = basket1.LastIndex - basket0.LastIndex;
                    
                    basket0.Amount = 1;
                    basket0.Number = fruits[i];
                    basket0.LastIndex = i;
                }
            }

        }
        retVal = Math.Max(retVal, basket0.Amount + basket1.Amount);

        return retVal;
    }
}