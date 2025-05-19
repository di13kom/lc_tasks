namespace LeetCode.Problems._150;

public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int sumCount = m + n;
        while (sumCount > 0)
        {
            if (n <= 0)
            {
                nums1[--sumCount] = nums1[--m];
            }
            else if (m <= 0)
            {
                nums1[--sumCount] = nums2[--n];
            }
            else if (nums1[m - 1] > nums2[n - 1])
            {
                nums1[--sumCount] = nums1[--m];
            }
            else
            {
                nums1[--sumCount] = nums2[--n];
            }

        }
    }
}
