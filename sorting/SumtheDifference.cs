Sum the Difference
Problem Description

Given an integer array A of size N.
You have to find all possible non-empty subsequence of the array of numbers and then, for each subsequence, find the difference between the largest and smallest numbers in that subsequence Then add up all the differences to get the number.

As the number may be large, output the number modulo 1e9 + 7 (1000000007).

NOTE: Subsequence can be non-contiguous.



Problem Constraints
1 <= N <= 10000

1<= A[i] <=1000



Input Format
First argument is an integer array A.



Output Format
Return an integer denoting the output.



Example Input
Input 1:

A = [1, 2]
Input 2:

A = [1]


Example Output
Output 1:

 1
Output 2:

 0


Example Explanation
Explanation 1:

All possible non-empty subsets are:
[1]    largest-smallest = 1 - 1 = 0
[2]    largest-smallest = 2 - 2 = 0
[1 2]  largest-smallest = 2 - 1 = 1
Sum of the differences = 0 + 0 + 1 = 1
So, the resultant number is 1
Explanation 2:

 Only 1 subsequence of 1 element is formed.

class Solution {
    int m = 1000000007;
    public int solve(List<int> A) {
        A.Sort();
        long min =0;
        long max = 0;
        long n = A.Count();
        for(int i=0;i<A.Count();i++)
        {
            long value = A[i];
            //Console.WriteLine(pow(2, n-1-i) + "-" + (n-1-i));
            //Console.WriteLine(pow(2, i) + "-" + (i));
            min = (min + (value *pow(2, n-1-i))%m)%m;
            max = (max + (value *pow(2, i))%m)%m;
        }
        
        return (int) ((max - min + m)%m);
    }
    
    public long pow(long b, long p)
    {
        if(p ==0)
        {
            return 1;
        }
        if((p&1) == 1)
        {
            return (b*pow((b*b)%m, p/2))%m;
        }
        else
        {
            return pow((b*b)%m, p/2);
            
        }
        
    }
}
