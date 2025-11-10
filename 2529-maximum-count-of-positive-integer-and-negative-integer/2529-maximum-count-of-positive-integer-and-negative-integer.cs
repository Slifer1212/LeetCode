public class Solution {
    public int MaximumCount(int[] nums) {
         int max = 0;
        int positives = 0;
        int negatives = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                positives++;
            }
            
            else if (nums[i] <= -1)
            {
                negatives++;
            }

            if (positives > negatives)
            {
                max = positives;
            }
            else
            {
                max = negatives;    
            }
            
        } 
        return max;
    }
}