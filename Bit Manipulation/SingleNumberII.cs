Single Number II
Problem Description

Given an array of integers, every element appears thrice except for one which occurs once.

Find that element which does not appear thrice.

NOTE: Your algorithm should have a linear runtime complexity.

Could you implement it without using extra memory?




Problem Constraints
2 <= A <= 5*106

0 <= A <= INTMAX



Input Format
First and only argument of input contains an integer array A.



Output Format
Return a single integer.



Example Input
Input 1:

 A = [1, 2, 4, 3, 3, 2, 2, 3, 1, 1]
Input 2:

 A = [0, 0, 0, 1]


Example Output
Output 1:

 4
Output 2:

 1


Example Explanation
Explanation 1:

 4 occurs exactly once in Input 1.
 1 occurs exactly once in Input 2.
 
 class Solution {
    public int singleNumber(List<int> A) {
        int m = 1000000007;
        int max = Int32.MinValue;
        
        for(int i=0;i<A.Count();i++)
        {
            if(A[i] > max)
            {
                max = A[i];
            }
        }
        
        int c = (int)Math.Log(max, 2.0) +1;
        int r =0;
        for(int i=0;i<c;i++)
        {
            int s =0;
            for(int j=0;j<A.Count();j++)
            {
                if(((A[j] >> i) & 1) == 1)
                {
                    s ++;
                }
            }
            
            if(s % 3 == 1)
            {
                r = r | (1 << i);
            }
        }
        return r;
    }
}
