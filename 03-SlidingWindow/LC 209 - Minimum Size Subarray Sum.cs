public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int minL= int.MaxValue;
        int l=0;
        int sum=0;

        for(int r =0; r<nums.Length; r++){
            sum+=nums[r];

            while(sum>=target){
                minL=Math.Min(minL,r-l+1);
                sum-=nums[l];
                l++;
            }
            

        }
        if(minL==int.MaxValue) return 0;
        return minL;
    }
}