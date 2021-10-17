Sorted Insert Position
Problem Description

Given a sorted array A of size N and a target value B, return the index (0-based indexing) if the target is found.
If not, return the index where it would be if it were inserted in order.

NOTE: You may assume no duplicates in the array. Users are expected to solve this in O(log(N)) time.



Problem Constraints
1 <= N <= 106



Input Format
First argument is an integer array A of size N.
Second argument is an integer B.



Output Format
Return an integer denoting the index of target value.



Example Input
Input 1:

A = [1, 3, 5, 6]
 B = 5
Input 2:

A = [1]
 B = 1


Example Output
Output 1:

2
Output 2:

0


Example Explanation
Explanation 1:

The target value is present at index 2.
Explanation 2:

The target value is present at index 0.

class Solution {
    public int searchInsert(List<int> A, int B) {
        int l =0;
        int h = A.Count() -1;
        
        while(l<=h)
        {
            int m = (l +h)/2;
            if(A[m] == B)
            {
                return m;
            }
            
            if(A[m] < B)
            {
                l = m +1;
            }
            else
            {
                h = m -1;
            }
        }
        
        return h +1;
    }
}
