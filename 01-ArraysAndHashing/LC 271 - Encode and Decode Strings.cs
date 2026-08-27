using System.Text;

public class Solution {
    public string Encode(IList<string> strs) {
        var sb = new StringBuilder();
        foreach (var str in strs) {
            sb.Append(str.Length).Append('#').Append(str);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        var res = new List<string>();
        int i = 0;

        while (i < s.Length) {
            // Find the delimiter '#' starting from index i
            int j = s.IndexOf('#', i);
            int length = int.Parse(s[i..j]); // Slice length string using range operator
            
            i = j + 1; // Skip the '#'
            res.Add(s.Substring(i, length)); // Grab the full word directly
            
            i += length; // Move index to start of next length prefix
        }

        return res;
    }
}