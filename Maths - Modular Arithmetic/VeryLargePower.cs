Very Large Power
Problem Description

Given two Integers A, B. You have to calculate (A ^ (B!)) % (1e9 + 7).

"^" means power ,

"%" means "mod", and

"!" means factorial.



Problem Constraints
1 <= A, B <= 5e5



Input Format
First argument is the integer A

Second argument is the integer B



Output Format
Return one integer, the answer to the problem



Example Input
Input 1:

A = 1
B = 1
Input 2:

A = 2
B = 2


Example Output
Output 1:

1
Output 2:

4


Example Explanation
Explanation 1:

 1! = 1. Hence 1^1 = 1.
Explanation 2:

 2! = 2. Hence 2^2 = 4.
 
 class Solution {
    public int solve(int A, int B) {
        int m = 1000000007;
        
        int f = (int)F(B);
        int r = (int)pow(A, f);
        
        return r;
    }
    
    public long F(long a)
    {
        int m = 1000000007;
        if(a == 1 || a==0)
        {
            return 1;
        }
        return (a * F(a-1)) % (m-1);
    }
    
    public long pow(long a, int n)
    {
        int m = 1000000007;
        
        if(n == 0)
        {
            return 1;
        }
        if((n &1) == 1)
        {
            return (a * pow((a*a)%m, n/2))%m;
        }
        else
        {
            return pow((a*a)%m, n/2);
        }
    }
}
