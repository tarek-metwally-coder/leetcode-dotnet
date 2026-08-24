public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freqMap = new Dictionary<int, int>();
        foreach (var num in nums) {
            freqMap[num] = freqMap.GetValueOrDefault(num, 0) + 1;
        }

        // Max Heap using frequency as priority
        var maxHeap = new PriorityQueue<int, int>(
            Comparer<int>.Create((x, y) => y.CompareTo(x))
        );

        foreach (var (num, count) in freqMap) {
            maxHeap.Enqueue(num, count);
        }

        var res = new int[k];
        for (int i = 0; i < k; i++) {
            res[i] = maxHeap.Dequeue();
        }

        return res;
    }
}
/*
using bucket sort approch instead 
public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freqMap = new Dictionary<int, int>();
        foreach (var num in nums) {
            freqMap[num] = freqMap.GetValueOrDefault(num, 0) + 1;
        }

        // Index = frequency (0 to N), Value = list of numbers with that frequency
        var buckets = new List<int>[nums.Length + 1];
        foreach (var (num, count) in freqMap) {
            buckets[count] ??= new List<int>();
            buckets[count].Add(num);
        }

        var res = new int[k];
        int index = 0;

        // Iterate backward from highest possible frequency down to 1
        for (int i = buckets.Length - 1; i >= 0 && index < k; i--) {
            if (buckets[i] == null) continue;
            foreach (var num in buckets[i]) {
                res[index++] = num;
                if (index == k) break;
            }
        }

        return res;
    }
}

*/