public class Solution {
    public string ShortestCommonSupersequence(string str1, string str2) {
        int n=str1.Length;
        int m=str2.Length;

        int[,] dp=new int[n+1,m+1];

        for(int i=1;i<=n;i++)
        {
            for(int j=1;j<=m;j++)
            {
                if(str1[i-1]==str2[j-1])
                dp[i,j]=1+dp[i-1,j-1];
                else
                dp[i,j]=Math.Max(dp[i-1,j],dp[i,j-1]);
            }
        }
        int column=m;
        int row=n;
        StringBuilder result=new();
        while(row>0&&column>0)
        {
            if(str1[row-1]==str2[column-1])
            {
                result.Append(str1[row-1]);
                row--;
                column--;
            }
            else
            {
              
             
                if(dp[row-1,column]>dp[row,column-1])
                {
                    
                    result.Append(str1[row-1]);
                    row--;
                    

                }
                else
                {
                  
                  result.Append(str2[column-1]);
                  column--;
                }


            }
        }
        while(row>0)
        {
            result.Append(str1[row-1]);
            row--;
        }
          while(column>0)
        {
            result.Append(str2[column-1]);
            column--;
        }
        char[] resultarr=result.ToString().ToCharArray();
        Array.Reverse(resultarr);
    
        return new String(resultarr);
        
    }
    
}