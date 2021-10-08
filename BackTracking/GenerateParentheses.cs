Generate all Parentheses II
Problem Description

Given an integer A pairs of parentheses, write a function to generate all combinations of well-formed parentheses of length 2*A.



Problem Constraints
1 <= A <= 20



Input Format
First and only argument is integer A.



Output Format
Return a sorted list of all possible paranthesis.



Example Input
Input 1:

A = 3
Input 2:

A = 1


Example Output
Output 1:

[ "((()))", "(()())", "(())()", "()(())", "()()()" ]
Output 2:

[ "()" ]


Example Explanation
Explanation 1:

 All paranthesis are given in the output list.
Explanation 2:

 All paranthesis are given in the output list.
 
 using System.Text;

class Solution {
    private List<string> fl = new List<string>();
    private int k;
    public List<string> generateParenthesis(int A) {
        k = A;
        
        M(0, 0, new List<string>());
        //Console.WriteLine(fl.Count());
        return fl;
    }
    
    public void M(int o, int c, List<string> temp)
    {
        if(o == k && c == k)
        {
            var sb = new StringBuilder();
            for(int i=0;i<temp.Count();i++)
            {
                sb.Append(temp[i]);
            }
            fl.Add(sb.ToString());
        }
        if(o < k)
        {
            temp.Add("(");
            M(o +1, c, temp);
            temp.RemoveAt(temp.Count()-1);
        }
        if(c < o)
        {
            temp.Add(")");
            M(o, c+1, temp);
            temp.RemoveAt(temp.Count()-1);
        }
    }
}
