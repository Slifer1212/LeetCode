public class Solution {
    public int Search(int[] nums, int target) {
    int L = nums.Length - 1 ;
        int R = 0;

        while (L >= R)
        {
            int middle = L + (R - L) / 2;

            if (nums[middle] == target)
            {
                return middle;
            }
            if(nums[middle] < target)
            {
                R  = middle + 1;
            }
            else 
                L = middle - 1;
        }

        return -1;
    }
}