public class Solution {
    public void SetZeroes(int[][] nums) {
	
	HashSet<int> row=new HashSet<int>();
	HashSet<int> column=new HashSet<int>();
	
	for(int i=0;i<nums.Length;i++)
	{
	
		for(int j=0;j<nums[0].Length;j++)
		{
		if(nums[i][j]==0)
		{
		row.Add(i);
		column.Add(j);
		}
	
		
		}

        
        

        
    }

    for(int i=0;i<nums.Length;i++)
    { 
        	for(int j=0;j<nums[0].Length;j++)
            {
                if(row.Contains(i)||column.Contains(j))
                {
                    nums[i][j]=0;
                }

            }

 

    }
}}