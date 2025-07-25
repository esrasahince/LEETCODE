public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        //col+columnnumber*row
    int left=0;
    int right=matrix.Length*matrix[0].Length-1;
    while(left<=right)
    {
        int middle=left+(right-left)/2;
        int row=middle/matrix[0].Length;
        int column=middle%matrix[0].Length;
        if(matrix[row][column]==target)
        return true;
        else if(matrix[row][column]>target)
        {
            right=middle-1;
        }
        else 
        {
            left=middle+1;
        }
        
        
    }

    return false;
        
     
    }
}