public class Solution {
    public int MaxArea(int[] height) {
        int l = 0;
        int r = height.Length-1;
        int res = 0;

        while(l<r){

            int h= Math.Min(height[r],height[l]);
            int w= r-l;
            res=Math.Max(h*w,res);

            if(height[r]<height[l]){
                r--;
            }
            else{
                l++;
            }

        }
        return res;
    }
}