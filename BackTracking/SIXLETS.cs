SIXLETS
Problem Description

Given a array of integers A of size N and an integer B.

Return number of non-empty subsequences of A of size B having sum <= 1000.



Problem Constraints
1 <= N <= 20

1 <= A[i] <= 1000

1 <= B <= N



Input Format
The first argument given is the integer array A.

The second argument given is the integer B.



Output Format
Return number of subsequences of A of size B having sum <= 1000.



Example Input
Input 1:

    A = [1, 2, 8]
    B = 2
Input 2:

    A = [5, 17, 1000, 11]
    B = 4


Example Output
Output 1:

3
Output 2:

0


Example Explanation
Explanation 1:

 {1, 2}, {1, 8}, {2, 8}
Explanation 1:

 No valid subsequence
 
 class Solution {
    private List<int> l;
    private int k;
    private int p;
    public int solve(List<int> A, int B) {
        l = A;
        k = B;
        p = A.Count();
        return M(0, 0, 1);
    }
    
    public int M(int i, int s, int n)
    {
        if(n == k+1)
        {
           if(s <= 1000)
           {
               return 1;
           }
           else
           {
               return 0;
           }
        }
        if(i >= p)
        {
            return 0;
        }
        if(n > k)
        {
            return 0;
        }
        int c1 = M(i+1, s + l[i], n +1);
        int c2 = M(i+1, s, n);
        return c1 + c2;
    }
    
}
