// You are given an integer array prices where prices[i] is the price of a given stock on the ith day.
// On each day, you may decide to buy and/or sell the stock. You can only hold at most one share of the
// stock at any time. However, you can buy it then immediately sell it on the same day.
// Find and return the maximum profit you can achieve.
public class Solution {
    public int MaxProfit(int[] prices) {
        var profit = 0;
        
        if (prices. Length == 0) {
            return profit;
        }

        for (int i = 0; i < prices.Length - 1; i++) {
            if (prices[i + 1] > prices[i]) {
                profit += prices[i + 1] - prices[i];
            }
        }

        return profit;
    }
}