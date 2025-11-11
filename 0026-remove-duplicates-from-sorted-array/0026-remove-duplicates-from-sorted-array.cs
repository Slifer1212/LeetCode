public class Solution {
    public int RemoveDuplicates(int[] nums) {
 int unique = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != nums[unique])
            {
                unique++;
                nums[unique] = nums[i];
            }
            
        }
        return unique + 1;
    }
}