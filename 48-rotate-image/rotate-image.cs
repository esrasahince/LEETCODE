public class Solution {
    public void Rotate(int[][] matrix) {
        Transpose(matrix);
        Reflection(matrix);
       
        
    }
    public void Transpose(int[][] matrix)
    {
        int n=matrix.Length;
        for(int i=0;i<n;i++)
        {
            for(int j=i;j<n;j++)
            {
                if(i!=j)
                {
                int temp=matrix[i][j];
                matrix[i][j]=matrix[j][i];
                matrix[j][i]=temp;
                }
            }
        }
    }
    public void Reflection(int[][] matrix)
    {
        int n=matrix.Length;
        for(int i=0;i<n;i++)
        {
            int left=0;
            int right=n-1;
            while(left<right)
            {
                int temp=matrix[i][left];
                matrix[i][left]=matrix[i][right];
                matrix[i][right]=temp;
                left++;
                right--;
            }
        }

    }

}


