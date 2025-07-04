
public class Solution {
    public bool IsValidSudoku(char[][] board) {

       
        //row and column check
        for(int i=0;i<9;i++)
        {
            HashSet<char> checkrow=new();
            HashSet<char> checkcolumn=new();
            for(int j=0;j<9;j++)
            {
              if (board[i][j] != '.') {
            if (checkrow.Contains(board[i][j]))
                return false;
            checkrow.Add(board[i][j]);
        }

        if (board[j][i] != '.') {
            if (checkcolumn.Contains(board[j][i]))
                return false;
            checkcolumn.Add(board[j][i]);
        }
            }
            
        }
         for(int row=0;row<9;row+=3)
        {
            for(int column=0;column<9;column+=3)
            {
            HashSet<char> check=new();
            for(int j=row;j<row+3;j++)
            {
                for(int k=column;k<column+3;k++)
                {
                         if(board[j][k]=='.')
                       continue;
                    if(check.Contains(board[j][k]))
                    return false;
                    check.Add(board[j][k]);
                }
            }
            }
        } 
        return true;
      
        
    }}
