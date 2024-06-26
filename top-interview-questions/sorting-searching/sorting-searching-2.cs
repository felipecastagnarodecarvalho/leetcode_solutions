// You are a product manager and currently leading a team to develop a new product. Unfortunately,
// the latest version of your product fails the quality check. Since each version is developed
// based on the previous version, all the versions after a bad version are also bad.
// Suppose you have n versions [1, 2, ..., n] and you want to find out the first bad one,
// which causes all the following ones to be bad.
// You are given an API bool isBadVersion(version) which returns whether version is bad.
// Implement a function to find the first bad version. You should minimize the number of calls to the API.
/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */
public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int left = 1;
        int right = n;
        while (left < right) {
            int mid = left + (right - left) / 2; // This helps prevent overflow
            if (IsBadVersion(mid)) {
                right = mid; // If mid is bad, the first bad version is at mid or to the left of mid
            } else {
                left = mid + 1; // If mid is good, the first bad version is to the right of mid
            }
        }
        // At this point, left == right and pointing to the first bad version
        return left;
    }
}