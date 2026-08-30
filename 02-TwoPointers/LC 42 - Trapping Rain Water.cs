public class Solution {
    public int Trap(int[] height) {
        int l = 0;
        int r = height.Length-1;
        int mc = 0;
        int water=0;
        while(l<r){
            int h = Math.Min(height[l],height[r]);

            if (h>mc){
                mc=h;
            }
            else{
                water = mc-h + water;
            }

            if(height[l] > height[r]){
                r--;
            }else{
                l++;
            }
        }
        return water;
    }
}