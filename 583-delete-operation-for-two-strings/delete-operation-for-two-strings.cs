public class Solution {
    public int MinDistance(string word1, string word2) {
        int row=word1.Length;
        int column=word2.Length;

        int[,] matrix=new int[row+1,column+1];
        int lastcolumn=0;
        for(int i=1;i<row+1;i++)
        {
            for(int j=1;j<column+1;j++)
            {
                if(word1[i-1]==word2[j-1])
                {
                   
                    matrix[i,j]=1+matrix[i-1,j-1];

                }
                else
                {
                    matrix[i,j]=Math.Max(matrix[i-1,j],matrix[i,j-1]);
                }
            }
        }

        return row+column-2*matrix[row,column];


        
    }
}