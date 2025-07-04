public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<char>[] rowhash=new HashSet<char>[9];
        HashSet<char>[] columnhash=new HashSet<char>[9];
        HashSet<char>[] sectionhash=new HashSet<char>[9];
        for(int i=0;i<9;i++)
        {
            rowhash[i]=new();
            columnhash[i]=new();
            sectionhash[i]=new();
        }

        for(int i=0;i<9;i++)
        {
            for(int j=0;j<9;j++)
            {
                if(board[i][j]=='.')
                {
                    continue;
                }
                char item=board[i][j];
                int sectionindex=(i/3)*(3)+j/3;
                if(rowhash[i].Contains(item)||columnhash[j].Contains(item)||sectionhash[sectionindex].Contains(item))
                return false;
                rowhash[i].Add(item);
                columnhash[j].Add(item);
                sectionhash[sectionindex].Add(item);
            }
        }
        return true;
        
    }
}