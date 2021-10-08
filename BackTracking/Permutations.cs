Permutations
Problem Description

Given an integer array A of size N denoting collection of numbers , return all possible permutations.

NOTE:

No two entries in the permutation sequence should be the same.
For the purpose of this problem, assume that all the numbers in the collection are unique.
Return the answer in any order
WARNING: DO NOT USE LIBRARY FUNCTION FOR GENERATING PERMUTATIONS. Example : next_permutations in C++ / itertools.permutations in python.
If you do, we will disqualify your submission retroactively and give you penalty points.


Problem Constraints
1 <= N <= 9



Input Format
Only argument is an integer array A of size N.



Output Format
Return a 2-D array denoting all possible permutation of the array.



Example Input
A = [1, 2, 3]


Example Output
[ [1, 2, 3]
  [1, 3, 2]
  [2, 1, 3] 
  [2, 3, 1] 
  [3, 1, 2] 
  [3, 2, 1] ]


Example Explanation
All the possible permutation of array [1, 2, 3].

class Solution {
    private List<int> l;
    private List<List<int>> fl = new List<List<int>>();
    public List<List<int>> permute(List<int> A) {
        l = A;
        int c = A.Count();
        List<int> temp = new List<int>();
        for(int i=0;i<c;i++)
        {
            temp.Add(-1);
        }
        M(0, temp, c);
        return fl;
    }
    public void M(int ind, List<int> temp, int c)
    {
        if(ind == c)
        {
            var u = new List<int>();
            for(int i=0;i<temp.Count();i++)
            {
                u.Add(temp[i]);
            }

            fl.Add(u);
            return;
        }
        if(ind > c)
        {
            return;
        }

        for(int i=0; i<c;i++)
        {
            if(temp[i] == -1)
            {
                temp[i] = l[ind];
                M(ind +1, temp, c);
                temp[i] = -1;
            }
        }
    }
}
