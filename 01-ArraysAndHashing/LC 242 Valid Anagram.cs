// solution using array to store the frequency of characters in the first string and then decrementing the frequency based on the second string. If any character frequency goes below zero, it means the second string has an extra character that is not present in the first string, hence they are not anagrams. If all frequencies are zero at the end, then they are anagrams.
public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }
        int[] charFreq  = new int[26];

        for (int i=0; i<s.Length; i++){
            charFreq[s[i]-'a']++;
        }

        for (int i=0; i<t.Length; i++){
            charFreq[t[i]-'a']--;
            if(charFreq[t[i]-'a'] < 0){
                return false;
            }
        }
       return true;

    }
}