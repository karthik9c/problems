Aggressive cows
Problem Description

Farmer John has built a new long barn, with N stalls. Given an array of integers A of size N where each element of the array represents the location of the stall, and an integer B which represent the number of cows.

His cows don't like this barn layout and become aggressive towards each other once put into a stall. To prevent the cows from hurting each other, John wants to assign the cows to the stalls, such that the minimum distance between any two of them is as large as possible. What is the largest minimum distance?



Problem Constraints
2 <= N <= 100000
0 <= A[i] <= 109
2 <= B <= N



Input Format
The first argument given is the integer array A.
The second argument given is the integer B.



Output Format
Return the largest minimum distance possible among the cows.



Example Input
Input 1:

A = [1, 2, 3, 4, 5]
B = 3
Input 2:

A = [1, 2]
B = 2


Example Output
Output 1:

 2
Output 2:

 1


Example Explanation
Explanation 1:

 
John can assign the stalls at location 1,3 and 5 to the 3 cows respectively.
So the minimum distance will be 2.
Explanation 2:

 
The minimum distance will be 1.

class Solution {
    public int solve(List<int> A, int B) {
        
        int minGap = Int32.MaxValue;

        A.Sort();
        
        for(int i=1;i<A.Count();i++)
        {
            if(minGap > (A[i]-A[i-1]))
            {
                minGap = (A[i]-A[i-1]);
            }

        }
        
        int n = A.Count();
        int l = minGap;
        int h = A[n-1] - A[0];
        
        int ans =0;
        while(l<=h)
        {
            int m = (l+h)/2;
            
            if(IsDistanceSufficient(A, B, m))
            {
                ans = m;
                l = m+1;
                
            }
            else
            {
                h = m-1;
            }
        }
        
        return ans;
    }
    
    public bool IsDistanceSufficient(List<int> A, int B, int maxTime)
    {
        //Console.WriteLine(maxTime);
        int cows = 1;
        int baseIndex = A[0];
        
        for(int i=1;i<A.Count();i++)
        {
            if(A[i]-baseIndex >= maxTime)
            {
                baseIndex = A[i];
                cows++;
            }
        }
        
        if(cows >=B)
        {
            //Console.WriteLine("true");
            return true;
        }
        else
        {
            //Console.WriteLine("false");
            return false;
        }
    }
}
