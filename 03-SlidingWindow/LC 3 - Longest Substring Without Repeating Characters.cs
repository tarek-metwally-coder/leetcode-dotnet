public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int n = s.Length;
        if (n<=1) return n;

        int j = 0;
        int i = 0;
        HashSet<char> Set = [];
        int r = 0;
        while(j<n){

            if (!Set.Add(s[j])){
                //dublicate we need to keep removing and adding i till we get to the dublicate 
               
                while(s[i]!=s[j]){
                        Set.Remove(s[i]);
                        i++;
                }
                i++;
                


            }

            // check R at the end of each kloop if length of set is bigger set new max
            r = Math.Max(Set.Count,r);
            j++;
                
        }
        return r;
    }
}
// Diffrent solution  more readable.
// public class Solution {
//     public int LengthOfLongestSubstring(string s) {
//         int n = s.Length;
//         if (n <= 1) return n;

//         int i = 0;
//         HashSet<char> set = [];
//         int maxLen = 0;

//         for (int j = 0; j < n; j++) {
//             // While the window already contains the character, shrink from the left
//             while (set.Contains(s[j])) {
//                 set.Remove(s[i]);
//                 i++;
//             }
            
//             // Now it's safe to add the new character
//             set.Add(s[j]);
//             maxLen = Math.Max(maxLen, set.Count);
//         }

//         return maxLen;
//     }
// }