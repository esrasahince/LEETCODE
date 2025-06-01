public class Solution {
    public IList<IList<string>> SolveNQueens(int n) {
        char[,] board = new char[n, n];
        
        // Initialize board with dots
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                board[i, j] = '.';
            }
        }
        
        List<IList<string>> result = new();
        Backtracking(board, 0, 0, 0, result, n); // Start with 0 queens placed
        return result;
    }
    
    public void Backtracking(char[,] board, int row, int col, int queensPlaced, List<IList<string>> result, int n)
    {
        // Base case: all queens placed successfully
        if (queensPlaced == n)
        {
            List<string> temp = ConvertToStringList(board, n);
            result.Add(temp);
            return;
        }
        
        // Base case: reached end of board without placing all queens
        if (row >= n)
        {
            return;
        }
        
        // Calculate next position
        int nextRow = row;
        int nextCol = col + 1;
        if (nextCol >= n)
        {
            nextRow = row + 1;
            nextCol = 0;
        }
        
        // Option 1: Place queen at current position (if safe)
        if (IsSafe(board, row, col, n))
        {
            board[row, col] = 'Q';
            Backtracking(board, nextRow, nextCol, queensPlaced + 1, result, n);
            board[row, col] = '.'; // Backtrack
        }
        
        // Option 2: Don't place queen at current position
        Backtracking(board, nextRow, nextCol, queensPlaced, result, n);
    }
    
    public bool IsSafe(char[,] board, int row, int col, int n)
    {
        // Check row (left side)
        for (int j = 0; j < col; j++)
        {
            if (board[row, j] == 'Q')
                return false;
        }
        
        // Check column (above)
        for (int i = 0; i < row; i++)
        {
            if (board[i, col] == 'Q')
                return false;
        }
        
        // Check diagonal (top-left)
        for (int i = row - 1, j = col - 1; i >= 0 && j >= 0; i--, j--)
        {
            if (board[i, j] == 'Q')
                return false;
        }
        
        // Check diagonal (top-right)
        for (int i = row - 1, j = col + 1; i >= 0 && j < n; i--, j++)
        {
            if (board[i, j] == 'Q')
                return false;
        }
        
        // Check diagonal (bottom-left) - for positions we've already visited
        for (int i = row + 1, j = col - 1; i < n && j >= 0; i++, j--)
        {
            if (board[i, j] == 'Q')
                return false;
        }
        
        return true;
    }
    
    public List<string> ConvertToStringList(char[,] board, int n)
    {
        List<string> result = new();
        for (int i = 0; i < n; i++)
        {
            string rowStr = "";
            for (int j = 0; j < n; j++)
            {
                rowStr += board[i, j];
            }
            result.Add(rowStr);
        }
        return result;
    }
}