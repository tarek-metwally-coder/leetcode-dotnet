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