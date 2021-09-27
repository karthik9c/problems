//Factorial Array
//Problem Description

Groot has an array A of size N. Boring right? Groot thought so too, so he decided to construct another array B of the same size and defined elements of B as:

B[i] = factorial of A[i] for every i such that 1<= i <= N.

factorial of a number X denotes (1 x 2 x 3 x 4......(X-1) x (X)).
Now Groot is interested in the total number of non-empty subsequences of array B such that every element in the subsequence has the same non empty set of prime factors.

Since the number can be very large, return it modulo 109 + 7.

NOTE: A set is a data structure having only distinct elements. Eg : the set of prime factors of Y=12 will be {2,3} and not {2,2,3}



Problem Constraints
1 <= N <= 105
1 <= A[i] <= 106
Your code will run against a maximum of 5 test cases.



Input Format
Only argument is an integer array A of size N.



Output Format
Return an integer deonting the total number of non-empty subsequences of array B such that every element in the subsequence has the same set of prime factors modulo 109+7.



Example Input
Input 1:

 A = [2, 3, 2, 3]
Input 2:

 A = [2, 3, 4]


Example Output
Output 1:

 6
Output 2:

 4


Example Explanation
Explanation 1:

 Array B will be : [2, 6, 2, 6]
 The total possible subsequences are 6 : [2], [2], [2, 2], [6], [6], [6, 6].
Input 2:

 Array B will be : [2, 6, 24]
 The total possible subsequences are 4 : [2], [6], [24], [6, 24].


using System.Collections.Generic;

class Solution {
    int m = 1000000007;
    public int solve(List<int> A)
    {
        int m = Int32.MinValue;
        var d = new Dictionary<int, int>();
        int r = 0;
        A.Sort();
        for (int i = 0; i < A.Count(); i++)
        {
            if (A[i] > m)
            {
                m = A[i];
            }
        }
        
        int[] rl = puf(m);
        int c = 0;
        int pe = 0;
        for (int i = 0; i < A.Count(); i++)
        {
            c = findCount(rl, A[i], pe,c);
            pe = A[i];

            if(c !=0)
            {
                if (d.ContainsKey(c))
                {
                    d[c] = d[c] + 1;
                }
                else
                {
                    d[c] = 1;
                }
            }
        }
        foreach (var di in d)
        {
            int v = di.Value;
            r += ((int)(Math.Pow(2, v) - 1)) * 1;
        }
        return r;
    }
    
    public  int[] puf(int A)
    {
        int[] r = new int[A + 1];
        r[1] = 1;
        for (long i = 2; i <= A; i++)
        {
            if (r[i] == 0)
            {
                r[i] = (int)-1;
                for (long j = i * i; j <= A; j += i)
                {
                    if (r[j] == 0)
                    {
                        r[j] = (int)i;
                    }
                }
            }

        }
        return r;

    }

    public int findCount(int[] r, int A, int s, int pc)
    {
        int c =0;
        for(int i=s+1;i<=A;i++)
        {
            if(r[i] == -1)
            {
                c++;
            }
        }
        return c + pc;
    }
    
}
