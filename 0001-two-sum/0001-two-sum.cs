public class Solution {
    
    public int[] TwoSum(int[] nums, int target) {
        
        for (int i = 0 ; nums.Length >i ; i++){
            for (int j = i+1 ; nums.Length >j; j++ ){
                if(nums[j] + nums[i] ==  target){
                    return new int[]{i,j};
                }
            }
        }
        return null;

    }
}