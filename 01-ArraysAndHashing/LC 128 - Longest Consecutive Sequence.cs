public class Solution {
    public int LongestConsecutive(int[] nums) {
        // Pass nums array directly into HashSet constructor
        var lookup = new HashSet<int>(nums);
        int maxSeqL = 0;

        foreach (int num in lookup) {
            // Only start counting if 'num' is the beginning of a sequence
            if (!lookup.Contains(num - 1)) {
                int currentSeqLength = 1;
                int currentNum = num;

                while (lookup.Contains(currentNum + 1)) {
                    currentSeqLength++;
                    currentNum++;
                }

                maxSeqL = Math.Max(maxSeqL, currentSeqLength);
            }
        }

        return maxSeqL;
    }
}