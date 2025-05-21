public class Solution {
    public int LongestCommonSubsequence(string s1, string s2) {
           // code here
        int m=s1.Length;
        int n=s2.Length;
        Dictionary<(int,int),int> memo=new();

        return TopDown(s1,s2,m-1,n-1,memo);
        
    }
     public int TopDown(string s1, string s2,int m,int n,Dictionary<(int,int),int> memo)
    {
        if(m<0||n<0)
        return 0;

        if(memo.ContainsKey((m,n)))
        return memo[(m,n)];

        if(s1[m]==s2[n])
        memo[(m,n)]=1+TopDown(s1,s2,m-1,n-1,memo);
        else
        memo[(m,n)]=Math.Max(TopDown(s1,s2,m-1,n,memo),TopDown(s1,s2,m,n-1,memo));

        return memo[(m,n)];
        
        
    }
}