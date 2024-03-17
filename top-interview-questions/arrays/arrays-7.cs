// You are given a large integer represented as an integer array digits,
// where each digits[i] is the ith digit of the integer. The digits are
// ordered from most significant to least significant in left-to-right order.
// The large integer does not contain any leading 0's.
// Increment the large integer by one and return the resulting array of digits.
public class Solution {
    public int[] PlusOne(int[] digits) {
        digits[digits.Length - 1]++;

        var invertedDigits = new List<int>();
        var increaseNext = false;
        
        for (int i = digits.Length - 1; i >= 0; i--) {
            if (increaseNext) {
                digits[i]++;
                increaseNext = false;
            }
            
            if (digits[i] > 9) {
                digits[i] = 0;
                increaseNext = true;
            }
            
            invertedDigits.Add(digits[i]);
            
            if (increaseNext && i == 0 && digits[i] == 0) {
                invertedDigits.Add(1);
            }
        }
        
        invertedDigits.Reverse();
            
        return invertedDigits.ToArray();
    }   
}