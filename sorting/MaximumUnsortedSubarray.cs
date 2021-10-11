Maximum Unsorted Subarray
Problem Description

Given an array A of non-negative integers of size N. Find the minimum sub-array Al, Al+1 ,..., Ar such that if we sort(in ascending order) that sub-array, then the whole array should get sorted. If A is already sorted, output -1.



Problem Constraints
1 <= N <= 1000000
1 <= A[i] <= 1000000



Input Format
First and only argument is an array of non-negative integers of size N.



Output Format
Return an array of length 2 where First element denotes the starting index(0-based) and second element denotes the ending index(0-based) of the sub-array. If the array is already sorted, return an array containing only one element i.e. -1.



Example Input
Input 1:

A = [1, 3, 2, 4, 5]
Input 2:

A = [1, 2, 3, 4, 5]


Example Output
Output 1:

[1, 2]
Output 2:

[-1]


Example Explanation
Explanation 1:

If we sort the sub-array A1, A2, then the whole array A gets sorted.
Explanation 2:

A is already sorted.

class Solution {
    public List<int> subUnsort(List<int> A) {
        int leftInd = -1;
        int rightInd = -1;
        int i=0;
        int j =A.Count()-1;
        
        while(i<(A.Count()-1))
        {
            if(A[i]<=A[i+1])
            {
                i++;
            }
            else
            {
                leftInd = i;
                //Console.WriteLine(leftInd);
                break;
            }
        }
        //Console.WriteLine(leftInd);
        if(leftInd == -1)
        {
            return new List<int>(){-1};
        }
        //Console.WriteLine("i");
        while(j>0)
        {
            if(A[j]>=A[j-1])
            {
                //Console.WriteLine(j);
                j--;
            }
            else
            {
                rightInd = j;
                //Console.WriteLine(j);
                break;
            }
        }
        
        if(rightInd == -1)
        {
            return new List<int>(){-1};
        }
        
        int min = Int32.MaxValue;
        int max = Int32.MinValue;
        for(int x=leftInd;x<=rightInd;x++)
        {
            if(min> A[x])
            {
                min = A[x];
            }
            if(max < A[x])
            {
                max = A[x];
            }
        }
        
        var r = new List<int>();
        for(int x=0;x<A.Count();x++)
        {
            if(min<A[x])
            {
                r.Add(x);
                break;
            }
        }
        for(int x=A.Count()-1;x>=0;x--)
        {
            if(max >A[x])
            {
                r.Add(x);
                break;
            }
        }
        
        return r;
    }
}
