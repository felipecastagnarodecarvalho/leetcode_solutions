// You are climbing a staircase. It takes n steps to reach the top.
// Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
public class Solution {
    public int ClimbStairs(int n) {
        if (n == 1) {
            return 1;
        }
        
        int first = 1;
        int second = 2;
        
        for (int i = 3; i <= n; i++) {
            int third = first + second;
            first = second;
            second = third;
        }
        
        Console.WriteLine(second);
        
        return second;
    }
}