public class Solution {
    public int MinDistance(string word1, string word2) {

        int row=word1.Length;
        int column=word2.Length;
        int[,] matrix=new int[row+1,column+1];
        for(int i=0;i<row+1;i++)
        {
            for(int j=0;j<column+1;j++)
            {
                if(i==0||j==0)
                {
                    matrix[i,j]=Math.Max(i,j);
                    continue;
                }
                if(word1[i-1]==word2[j-1])
                {
                    matrix[i,j]=matrix[i-1,j-1];

                }
                else
                {
                    matrix[i, j] = 1 + Math.Min(matrix[i - 1, j], Math.Min(matrix[i, j - 1], matrix[i - 1, j - 1]));
               
                }
            }
   
        }
     
      return matrix[row,column];
      
        
    }
}