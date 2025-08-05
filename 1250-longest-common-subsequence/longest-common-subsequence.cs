public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        if(text1==null||text2==null)
        return 0;
        Dictionary<(int,int),int> memo=new();
        return DP(text1,text2,text1.Length-1, text2.Length-1,memo);
        
    }
    public int DP(string s1, string s2, int index1,int index2,Dictionary<(int,int),int> memo)
    {
        if(index1<0||index2<0)
        return 0;
        if(memo.ContainsKey((index1,index2)))
        return memo[(index1,index2)];
        int result=0;
        if(s1[index1]==s2[index2])
        {
            result=1+DP(s1,s2,index1-1,index2-1,memo);
        }
        else
        {
            result+=Math.Max(DP(s1,s2,index1-1,index2,memo),DP(s1,s2,index1,index2-1,memo));

        }
        memo[(index1,index2)]=result;
        return result;
        
    }
}