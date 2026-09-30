public class Solution {
    public int MaxProfit(int[] prices) {
        int n = prices.Length;
        if(n==1) return 0;
        int j = 1;
        int i = 0;

        int profit = 0;
        while(j<n){
            
            int currProfit = prices[j] - prices[i];

            profit = Math.Max(currProfit,profit);

            if(prices[i]>prices[j]){
                i=j;
            }
            j++;


        }
        return profit;
    }
}