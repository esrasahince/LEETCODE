public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {

        int[,] matrix=new int[text1.Length+1,text2.Length+1];
        int maxvalue=0;

        for(int i=1; i<text1.Length+1;i++)
        { 
            for(int j=1;j<text2.Length+1;j++)
            {
                if(text1[i-1]==text2[j-1])
                { 
                  
                    matrix[i,j]=matrix[i-1,j-1]+1;
               
                     
                }
                else
                {
                    matrix[i,j]=Math.Max(matrix[i-1,j],matrix[i,j-1]);

                }
          

            }
        }

        return matrix[text1.Length,text2.Length];
        
    }
}