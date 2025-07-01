public class Solution {
    public int LongestPalindromeSubseq(string s) {
        string reversed=new String(s.Reverse().ToArray());
        Dictionary<(int,int),string> memo=new();
        string result= DP(s,reversed,s.Length-1,s.Length-1,memo);
        return result.Length;
        
    }
    public string DP(string x, string y, int xi,int yi,Dictionary<(int,int),string> memo)
    {
        if(xi<0||yi<0)
        return "";
        if(memo.ContainsKey((xi,yi)))
        return memo[(xi,yi)];
        if(x[xi]==y[yi])
        memo[(xi,yi)]=DP(x,y,xi-1,yi-1,memo)+x[xi];
        else
        {
        string left=DP(x,y,xi-1,yi,memo);
        string right=DP(x,y,xi,yi-1,memo);
        memo[(xi,yi)]=left.Length>right.Length?left:right;
        }
        return memo[(xi,yi)];
    }
}