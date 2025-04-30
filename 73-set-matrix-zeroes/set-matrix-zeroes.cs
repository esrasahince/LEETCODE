public class Solution {
    public void SetZeroes(int[][] matrix) {
        
        //ilk column ve ilk satırı mark bolgesi olarak kullanacagız. 
        //Ama bunu yapmadan once buralarda kendiliğinden sıfır var mı
        //varsa zaten burası da full sıfır olcak

        int row=matrix.Length;
        int column=matrix[0].Length;

        bool firstrow=false;
        bool firstcolumn=false;

        //1. satır ve 1. sutun kontrolü

        for(int i=0;i<column;i++)
        {
            if(matrix[0][i]==0)
            firstrow=true;
        }
        
        for(int i=0;i<row;i++)
        {
            if(matrix[i][0]==0)
            firstcolumn=true;
        }

        //2. 1. satır ve 1. sutunu işaretci olarak kullanıcaz
        
        for(int i=1;i<row;i++)
        {
             for(int j=1;j<column;j++)
            {
                if(matrix[i][j]==0)
                {
                    //eleman sıfır sa git ilk satır ve ilk sutunu işaretle
                    matrix[i][0]=0;
                    matrix[0][j]=0;
                }
            }  
        }
        
        //3. işaretli satırları ve sutunları 0 ile doldur
         for(int i=1;i<column;i++)
        {
            if(matrix[0][i]==0)
            {
                for(int j=1;j<row;j++)
                {
                    matrix[j][i]=0;
                }
            }
        }
            for(int i=1;i<row;i++)
        {
            if(matrix[i][0]==0)
            {
                for(int j=1;j<column;j++)
                {
                    matrix[i][j]=0;
                }
            }
        }

        //4 son olarakta first row, firtst column 0 ile doldurulur. 
        
        if(firstrow)
        {
            for(int i=0;i<column;i++)
        {
           matrix[0][i]=0;
        }
        }
            
        if(firstcolumn)
        {
            for(int i=0;i<row;i++)
        {
           matrix[i][0]=0;
        }
        }

        
    }
}