// You are given an array prices where prices[i] is the price of a given stock on the ith day.
// You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
// Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.
public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length == 0) return 0;

        int minPrice = int.MaxValue;
        int maxProfit = 0;

        foreach (int price in prices) {
            // If we find a new minimum price, we set it
            if (price < minPrice) {
                minPrice = price;
            }
            // Otherwise, we check if selling at the current price is more profitable
            else if (price - minPrice > maxProfit) {
                maxProfit = price - minPrice;
            }
        }

        return maxProfit;
    }
}