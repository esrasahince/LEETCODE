public class NumArray {

    int [] nums;
    public NumArray(int[] nums) {
        this.nums=nums;
        int prev=0;
        for(int i=0;i<nums.Length;i++)
        {
            prev=prev+nums[i];
            nums[i]=prev;
        }
        
    }
    
    public int SumRange(int left, int right) {
         int firts=0;
        if(left==0)
        {
            return nums[right];
        }
        return nums[right]-this.nums[left-1];

        
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */