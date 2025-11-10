public class Solution {
    public bool IsPalindrome(int x) {
        int remainder = 0;
        int sum = 0;
        int temp = x;
        while(x >  0){
            remainder = x %10;
            sum = (sum*10) + remainder ;
            x /= 10;
        }
        if (temp == sum)
        return true;
        else return false;
    }
}