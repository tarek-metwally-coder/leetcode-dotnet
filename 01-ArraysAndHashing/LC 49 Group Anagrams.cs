using System;
using System.Collections.Generic;

public class Solution {
    // Approach 1: Categorize by Sorting
    // Time Complexity: O(N * L log L) | Space Complexity: O(N * L)
    // Best for clean, readable production code with zero custom hashing overhead.
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var map = new Dictionary<string, List<string>>();

        for (int i = 0; i < strs.Length; i++) {
            char[] chars = strs[i].ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);

            if (!map.TryGetValue(key, out var list)) {
                list = new List<string>();
                map[key] = list;
            }
            list.Add(strs[i]);
        }

        return new List<IList<string>>(map.Values);
    }

    /*
    // Approach 2: Categorize by Frequency Count (Linear Time)
    // Time Complexity: O(N * L) | Space Complexity: O(N * L)
    // Uses a serialized frequency array ("1,0,2...") as a string key to avoid custom comparers.
    public IList<IList<string>> GroupAnagrams_Frequency(string[] strs) {
        var map = new Dictionary<string, List<string>>();

        foreach (string s in strs) {
            int[] count = new int[26];
            foreach (char c in s) {
                count[c - 'a']++;
            }

            string key = string.Join(",", count);

            if (!map.TryGetValue(key, out var list)) {
                list = new List<string>();
                map[key] = list;
            }
            list.Add(s);
        }

        return new List<IList<string>>(map.Values);
    }
    */
}