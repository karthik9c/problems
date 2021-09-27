Odd Fibonacci
Problem Description

Given two integers A and B representing an interval [A, B].

Fibonacci sequence is a sequence whose definition is as follows:

F[1] = 1 , F[2] = 1

F[i] = F[i-1] + F[i-2] for i > 2

Your task is to find the count of integers x in the range [A, B] such that F[x] is odd.



Problem Constraints
1 <= A <= 109
1 <= B <= 109
A <= B


Input Format
The first argument given is an integer A.

The second argument given is an integer B.



Output Format
Return the count of integers x in the range [A, B] such that F[x] is odd.



Example Input
Input 1:

 A = 2
 B = 6
Input 2:

 A = 6
 B = 20


Example Output
Output 1:

 3
Output 2:

 10


Example Explanation
Explanation 1:

 All x and their F[x] values:
    x = 2, F[x] = 1
    x = 3, F[x] = 2
    x = 4, F[x] = 3
    x = 5, F[x] = 5
    x = 6, F[x] = 8
 From the above values only three values are odd.

Observations:
Fibonacci series is 1 1 2 3 5 8 13 21 34 55....
we observe that it's a series of odd and even numbers as follows:
1 1 2 3 5 8 13 21 34...
o o e o  o  e  o   o   e...
         since e+o = o and o+o = e
         we observe that an even number occurs at every 3rd number in the series.
  2.   ans = count of odd numbers in F[A,B] = range length - (count of even in F[A,B])
  3.  range length = B-A+1
   4. count of even in F[A,B] = count of even in F[1,B] - count of even in F[1,A-1].
   5. since at every 3 multiple, an even Fibonacci number appears in series, count of even in F[1,B] = B/3.
       similarly, count even in F[1,A-1] = (A-1)/3
   6.  ans = (B-A+1) - (B/3 - (A-1)/3)
   
  class Solution {
    public int solve(int A, int B) {
        int t = B-A+1;
        int e1b = B/3;
        int e1a = (A-1)/3;
        return t - (e1b-e1a);
    }
    
}

