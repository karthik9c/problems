Inversion count in an array
Problem Description
Given an array of integers A. If i < j and A[i] > A[j] then the pair (i, j) is called an inversion of A. Find the total number of inversions of A modulo (109 + 7).



Problem Constraints
1 <= length of the array <= 100000

1 <= A[i] <= 10^9



Input Format
The only argument given is the integer array A.



Output Format
Return the number of inversions of A modulo (109 + 7).



Example Input
Input 1:

A = [3, 2, 1]
Input 2:

A = [1, 2, 3]


Example Output
Output 1:

3
Output 2:

0


Example Explanation
Explanation 1:

 All pairs are inversions.
Explanation 2:

 No inversions.
 
 class Solution {
    long count =0;
    int modulo = 1000000007;
    public int solve(List<int> A) {
        MergeSort(A, 0, A.Count()-1);
        
        return (int)count;
    }
    
    public void MergeSort(List<int> A, int s, int e)
    {
        if(s < e)
        {
            int mid = (s +e)/2;
            MergeSort(A, s, mid);
            MergeSort(A, mid+1, e);
            Merge(A, s, e, mid);
        }
    }
    
    public void Merge(List<int> A, int l, int r, int m)
    {
        int[] left = new int[m-l+1];
        int[] right = new int[r-m];
        
        for(int i=l;i<=m;i++)
        {
            left[i-l] = A[i];
        }
        for(int i=m+1;i<=r;i++)
        {
            right[i-(m+1)] = A[i];
        }
        int p = 0;
        int q = 0;
        int fs = l;

        
        while(p <left.Count() && q <right.Count())
        {
            if(left[p] <= right[q])
            {
                A[fs] = left[p];
                p++;
            }
            else
            {
                count = (count + (left.Count()-p))%modulo;
                A[fs] = right[q];
                q++;
            }
            fs++;
        }
        
        while(p<left.Count())
        {
            A[fs] = left[p];
            p++;
            fs++;
        }
        while(q<right.Count())
        {
            A[fs] = right[q];
            q++;
            fs++;
        }
    }

    
}
