public class Solution {
    public int LongestPalindromeSubseq(string s) {
       string reversed = new string(s.Reverse().ToArray()); 
        int lengt=s.Length;

        //LCS
        int[,] board=new int[lengt+1,lengt+1];
        for(int i=1;i<lengt+1;i++)
        {
          for(int j=1;j<lengt+1;j++)
          {
              if(s[i-1]==reversed[j-1])
              {
                board[i,j]=1+board[i-1,j-1];
              }
              else
              {
                board[i,j]=Math.Max(board[i-1,j],board[i,j-1]);
              }
          }

        }
        return board[lengt,lengt];
        
    }
}