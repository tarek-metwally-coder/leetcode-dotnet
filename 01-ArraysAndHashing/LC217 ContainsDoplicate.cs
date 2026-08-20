using System.Collections.Generic;
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> lookup = new();
        foreach (int i in nums){
            if(!lookup.Add(i)){
                return true;
            }
        }
        return false;
    }
}