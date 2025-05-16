public class Solution {
    public bool CanPartition(int[] nums) {
        int totalsum=0;
        for(int i=0;i<nums.Length;i++)
        {
            totalsum+=nums[i];

        }
        if(totalsum%2!=0)
        return false;
        return BottomUp(nums,totalsum/2);
        
    }
     public bool BottomUp(int[] nums,int sum)
    { 

        bool[,] matrix=new bool[nums.Length+1,sum+1];
          // If sum is 0, then answer is true (empty subset)
        for (int i = 0; i <= nums.Length; i++) {
            matrix[i, 0] = true;
        }

        for(int i=1;i<nums.Length+1;i++)  //index
        {
            for(int j=1;j<sum+1;j++)  //sum
            {
               if(nums[i-1]>j)
               {
                matrix[i,j]=matrix[i-1,j];
               }
               else
               {
                matrix[i,j]=matrix[i-1,j]||matrix[i-1,j-nums[i-1]];

               }
            }
        }
        return matrix[nums.Length,sum];


    }
}
