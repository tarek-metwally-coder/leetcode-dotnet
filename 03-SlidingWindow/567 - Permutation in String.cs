public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length>s2.Length) return false;
        int[] s1count = new int[26];
        int[] s2count = new int[26];
        char a='a';
        for (int i=0;i<s1.Length;i++){
            s1count[s1[i]-a]++;
            s2count[s2[i]-a]++;
        }
        if (AreArraysEqual(s1count,s2count)) return true;

        int l=0;
        for (int r = s1.Length;r<s2.Length;r++){

            s2count[s2[r]-a]++;

            s2count[s2[l]-a]--;
            l++;
            if (AreArraysEqual(s1count,s2count)) return true;

        }
        


        return false;

    }
    public bool AreArraysEqual(int[] arr1,int[] arr2){
        for(int i=0;i<arr1.Length;i++){
            if (arr1[i]!=arr2[i]) {
                return false;
            }
        }
        return true;
    }
}