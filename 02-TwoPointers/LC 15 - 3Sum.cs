public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var res = new List<IList<int>>();
        for(int i=0;i<nums.Length;i++){
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            int l=i+1;
            int r = nums.Length-1;
            
            while(l<r){
                int currentsum=nums[i]+nums[l]+nums[r];

                if(currentsum>0)r--;
                else if(currentsum<0)l++;
                else{
                    res.Add([nums[i],nums[l],nums[r]]);
                    l++;
                    r--;
                    
                // skipDupes
                while(l<r && nums[l-1]==nums[l]) l++;
                while(l<r && nums[r+1]==nums[r]) r--;
                }

            }

        }
        
        return res;
    }
}