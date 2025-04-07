public class Solution {
    public int UniquePaths(int m, int n) {
        int[] tempRow=new int[n];
        for (int i = 0; i < n; i++)
        {
            tempRow[i] = 1;
        }
        for(int i=m-2;i>=0;i--)
        {
            for(int j=tempRow.Length-2;j>=0;j--)
            {
                tempRow[j]=tempRow[j+1]+tempRow[j];
            }
        }
        return tempRow[0];
    }
}