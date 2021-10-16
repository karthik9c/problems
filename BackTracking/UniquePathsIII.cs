Unique Paths III
Problem Description

Given a matrix of integers A of size N x M . There are 4 types of squares in it:

1. 1 represents the starting square.  There is exactly one starting square.
2. 2 represents the ending square.  There is exactly one ending square.
3. 0 represents empty squares we can walk over.
4. -1 represents obstacles that we cannot walk over.
Find and return the number of 4-directional walks from the starting square to the ending square, that walk over every non-obstacle square exactly once.

Note: Rows are numbered from top to bottom and columns are numbered from left to right.



Problem Constraints
2 <= N * M <= 20
-1 <= A[i] <= 2



Input Format
The first argument given is the integer matrix A.



Output Format
Return the number of 4-directional walks from the starting square to the ending square, that walk over every non-obstacle square exactly once.



Example Input
Input 1:

A = [   [1, 0, 0, 0]
        [0, 0, 0, 0]
        [0, 0, 2, -1]   ]
Input 2:

A = [   [0, 1]
        [2, 0]    ]


Example Output
Output 1:

2
Output 2:

0


Example Explanation
Explanation 1:

We have the following two paths: 
1. (0,0),(0,1),(0,2),(0,3),(1,3),(1,2),(1,1),(1,0),(2,0),(2,1),(2,2)
2. (0,0),(1,0),(2,0),(2,1),(1,1),(0,1),(0,2),(0,3),(1,3),(1,2),(2,2)
Explanation 1:

Answer is evident here.

class Solution {
    int rowMax =0;
    int columnMax = 0;
    int zeroCount =0;
    public int solve(List<List<int>> A) {
        rowMax = A.Count();
        columnMax = A[0].Count();
        int row =0;
        int column = 0;
        
        for(int i=0;i<rowMax;i++)
        {
            for(int j=0;j<columnMax;j++)
            {
                if(A[i][j] == 1)
                {
                    row = i;
                    column = j;
                }
                if(A[i][j] == 0)
                {
                    zeroCount++;
                }
            }
        }
        int v = 0;
        return Route(row, column, ref A, ref v);
    }
    
    public int Route(int r, int c, ref List<List<int>> A, ref int z)
    {
        //Console.WriteLine(r +"-"+c + "-" + z);
        if(r>= rowMax || r <0 || c<0 || c >=columnMax) // corners excedding
        {
            //Console.WriteLine(r +"-"+c);
            return 0;
        }
        //Console.WriteLine(r +"-"+c);
        if(A[r][c] == -1)
        {
            return 0;
        }
        //Console.WriteLine(r +"-"+c);
        if(A[r][c] == 2)
        {
            //Console.WriteLine(r +"-"+c + "-"+ z+ "-" + zeroCount);
            if(z == zeroCount)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            
        }
        //Console.WriteLine(r +"-"+c);
        if(A[r][c] == 0)
        {
            z++;
        }
        int intialValue = A[r][c];
        A[r][c] = -1;
        int count = 0;
        //Console.WriteLine(z);
        count += Route(r-1, c, ref A, ref z); //top
        count += Route(r+1, c, ref A, ref z); //bottom
        count += Route(r, c-1, ref A, ref z); // left
        count += Route(r, c+1, ref A, ref z); // right
        
        if(intialValue == 0)
        {
            z--;
        }
        A[r][c] = intialValue;
        
        return count;
    }
}
