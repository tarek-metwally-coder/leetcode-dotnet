using System.Collections.Generic;

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> lookup = new();
        for(int i = 0; i < nums.Length; i++){
            int complement = target - nums[i];
            if (lookup.TryGetValue(complement, out int complementIndex)){
                return [complementIndex, i];
            }
            lookup[nums[i]] = i;
        }
        return null;
    }
}