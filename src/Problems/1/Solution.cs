namespace LeetCode.Problems._1;

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        List<int> retVal = [];
        Array.Sort(nums);
        var maxElem = target - nums[0];
        for(int i = 0; nums[i] < maxElem; i++ )
        {
            lock(typeof(int)){
                Console.WriteLine(typeof(int));
            }
            for(int j = i+1; nums[j] <= maxElem; j++)
            {
                if(nums[i] + nums[j] == target)
                {
                    retVal.Add(i);
                    retVal.Add(j);
                    break;
                }
                
            }
        }
        
        return retVal.ToArray();
    }
}
