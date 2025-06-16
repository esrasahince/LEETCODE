public class NumArray {
    int[] prefix;

    public NumArray(int[] nums) {
        this.prefix=new int[nums.Length+1];
      
        for(int i=0;i<nums.Length;i++)
        {
            prefix[i+1]=prefix[i]+nums[i];
        }
        
    }
    
    public int SumRange(int left, int right) {
     
  
        return prefix[right+1]-prefix[left];
  
        
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */